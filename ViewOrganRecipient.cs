using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ViewOrganRecipient : Form
    {
        public ViewOrganRecipient()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            populate();
            PopulateComboBoxes();

        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;



        int key = 0;

        private void populate()
        {
            Con.Open();
            string Query = "select * from OrganRecipientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewRecipientsGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void PopulateComboBoxes()
        {
            // Populate Gender ComboBox
            RGenCb.Items.Add("Male");
            RGenCb.Items.Add("Female");
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT OrganType FROM OrganTbl";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    ROrganCb.Items.Clear(); // Clear existing items before populating
                    while (reader.Read())
                    {
                        ROrganCb.Items.Add(reader["OrganType"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Reset()//field reset kortesi after diliting
        {
            RNameTb.Text = "";
            RAddressTb.Text = "";
            RAgeTb.Text = "";
            RPhoneTb.Text = "";
            RGenCb.SelectedIndex = -1;
            ROrganCb.SelectedIndex = -1;
            key = 0;
        }


        private void ViewRecipientsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // added this bit for some error purposes. code runs normally.
            RNameTb.Text = ViewRecipientsGrid.SelectedRows[0].Cells[1].Value.ToString();
            RAgeTb.Text = ViewRecipientsGrid.SelectedRows[0].Cells[2].Value.ToString();
            RGenCb.SelectedItem =ViewRecipientsGrid.SelectedRows[0].Cells[3].Value.ToString().Trim();
            RPhoneTb.Text = ViewRecipientsGrid.SelectedRows[0].Cells[4].Value.ToString();
            RAddressTb.Text = ViewRecipientsGrid.SelectedRows[0].Cells[5].Value.ToString();
            ROrganCb.SelectedItem = ViewRecipientsGrid.SelectedRows[0].Cells[6].Value.ToString();

            if (RNameTb.Text == "")
            {
                key = 0;
            }
            else
            {

                key = Convert.ToInt32(ViewRecipientsGrid.SelectedRows[0].Cells[0].Value.ToString());

            }

            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Recipient to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from OrganRecipientTbl where RNum=" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Recipient Successfully Deleted");
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a recipient to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Construct the update query
                    string query = "UPDATE OrganRecipientTbl SET RName = @RName, RAge = @RAge, RPhone = @RPhone, RAddress = @RAddress, RGender = @RGender, ROrgan = @ROrgan WHERE RNum = @RNum";

                    // Open the connection
                    Con.Open();

                    // Create a SQL command with parameters
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RName", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RAge", RAgeTb.Text);
                    cmd.Parameters.AddWithValue("@RPhone", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RAddress", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RGender", RGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ROrgan", ROrganCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RNum", key);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Recipient details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset the fields and refresh the grid
                    Reset();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Con.Close();
                    populate();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OrganEmployeeMainForm OrganEMain = new OrganEmployeeMainForm();
            OrganEMain.Show();
            this.Hide();
        }
    }
}
