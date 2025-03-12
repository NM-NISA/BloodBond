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
    public partial class OrganRecipient : Form
    {
        public OrganRecipient()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            PopulateComboBoxes();
        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        private void Reset()//field reset kortesi after saving
        {
            RNameTb.Text = "";
            RAddressTb.Text = "";
            RAgeTb.Text = "";
            RPhoneTb.Text = "";
            RGenCb.SelectedIndex = -1;
            ROrganType.SelectedIndex = -1;
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

                    ROrganType.Items.Clear(); // Clear existing items before populating
                    while (reader.Read())
                    {
                        ROrganType.Items.Add(reader["OrganType"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPhoneTb.Text == "" || RGenCb.SelectedIndex == -1 || ROrganType.SelectedIndex == -1 || RAddressTb.Text == "")
            {
                MessageBox.Show("Missing Info");
            }

            else
            {
                try
                {
                    string query = "insert into OrganRecipientTbl values ('" + RNameTb.Text + "', " + RAgeTb.Text + ",'" + RGenCb.SelectedItem.ToString() + "', '" + RPhoneTb.Text + "','" + RAddressTb.Text + "','" + ROrganType.SelectedItem.ToString() + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Recipient Successfully Registered");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OrganUserMainForm OUserMain = new OrganUserMainForm();
            OUserMain.Show();
            this.Hide();
        }
    }
}
