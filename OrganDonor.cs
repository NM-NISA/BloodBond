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
    public partial class OrganDonor : Form
    {
        public OrganDonor()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            PopulateComboBoxes();
        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        private void Reset()//field reset kortesi after saving
        {
            DNameTb.Text = "";
            DAddressTb.Text = "";
            DAgeTb.Text = "";
            DPhoneTb.Text = "";
            DGenCb.SelectedIndex = -1;
            DOrganCB.SelectedIndex = -1;
        }

        private void PopulateComboBoxes()
        {
            // Populate Gender ComboBox
            DGenCb.Items.Add("Male");
            DGenCb.Items.Add("Female");

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT OrganType FROM OrganTbl";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DOrganCB.Items.Clear(); // Clear existing items before populating
                    while (reader.Read())
                    {
                        DOrganCB.Items.Add(reader["OrganType"].ToString());
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
            if (string.IsNullOrWhiteSpace(DNameTb.Text) || string.IsNullOrWhiteSpace(DPhoneTb.Text) || string.IsNullOrWhiteSpace(DAgeTb.Text) || string.IsNullOrWhiteSpace(DAddressTb.Text) || DGenCb.SelectedIndex == -1 || DOrganCB.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that Age is a valid number and positive
            if (!int.TryParse(DAgeTb.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Phone Number (only digits and at least 10 characters)
            if (!long.TryParse(DPhoneTb.Text, out _) || DPhoneTb.Text.Length < 11)
            {
                MessageBox.Show("Please enter a valid phone number (at least 11 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    // Insert donor details into DonorTbl
                    string query = "INSERT INTO OrganDonorTbl (DName, DAge, DGender, DPhone, DAddress, DOrgan) VALUES ('" + DNameTb.Text + "', " + DAgeTb.Text + ", '" + DGenCb.SelectedItem.ToString() + "', '" + DPhoneTb.Text + "', '" + DAddressTb.Text + "', '" + DOrganCB.SelectedItem.ToString() + "')";

                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    // Update OrganStock in OrganTbl for the selected organ
                    string updateQuery = "UPDATE OrganTbl SET OrganStock = OrganStock + 1 WHERE OrganType = @OrganType";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, Con);
                    updateCmd.Parameters.AddWithValue("@OrganType", DOrganCB.SelectedItem.ToString());
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Donor Successfully Registered");

                    // Reset fields
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Con.Close();
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
