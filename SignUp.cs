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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object

        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;


        private void UserSelection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeSelection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Reset()//field reset kortesi after saving
        {
            UNameTb.Text = "";
            UPassTb.Text = "";
            UserSelection.Checked = false;
            EmployeeSelection.Checked = false;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UNameTb.Text) || string.IsNullOrWhiteSpace(UPassTb.Text))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UserSelection.Checked && !EmployeeSelection.Checked)
            {
                MessageBox.Show("Please select a user type (User or Employee).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userType = UserSelection.Checked ? "User" : "Employee";

            try
            {
                // Step 3: Database connection string
                SqlConnection Con = new SqlConnection(@"Data Source=DRDOOMSPC;Initial Catalog=BloodBondDb;Integrated Security=True;");

                string connectionString = @"Data Source=DRDOOMSPC;Initial Catalog=BloodBondDb;Integrated Security=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Step 4: Check if the username already exists
                    string checkQuery = "SELECT COUNT(*) FROM UserTbl WHERE UserID = @UserID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@UserID", UNameTb.Text);

                    con.Open();
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Step 5: Insert new user
                    string insertQuery = "INSERT INTO UserTbl (UserID, UserPass, UserType) VALUES (@UserID, @UserPass, @UserType)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@UserID", UNameTb.Text);
                    cmd.Parameters.AddWithValue("@UserPass", UPassTb.Text); // Hash password for security
                    cmd.Parameters.AddWithValue("@UserType", userType);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sign-up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Sign-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu MM = new MainMenu();
            MM.Show();
            this.Hide();
        }
    }
}
