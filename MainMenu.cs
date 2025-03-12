using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object


        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click_1(object sender, EventArgs e)//For About Button
        {
            using (AboutForm aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }

        }


        private void button1_Click(object sender, EventArgs e)//login as admin
        {
            AdminLogin AdminLog = new AdminLogin();
            AdminLog.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e) //For Login Button
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from UserTbl where UserID='" + UIdTb.Text + "' and UserPass='" + UPassTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Selection Select = new Selection();
                Select.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wong usenam or passwod");
            }
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)//exit button
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            SignUp Sign = new SignUp();
            Sign.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                // Query to check the user credentials and fetch UserType
                SqlDataAdapter sda = new SqlDataAdapter(
                    "SELECT COUNT(*), UserType FROM UserTbl WHERE UserID = @UserID AND UserPass = @UserPass GROUP BY UserType",
                    Con
                );

                // Add parameters to prevent SQL injection
                sda.SelectCommand.Parameters.AddWithValue("@UserID", UIdTb.Text);
                sda.SelectCommand.Parameters.AddWithValue("@UserPass", UPassTb.Text);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
                {
                    string userType = dt.Rows[0]["UserType"].ToString();

                    if (userType == "User")
                    {
                        // Redirect to User form
                        Selection SelectU = new Selection();
                        SelectU.Show();
                        this.Hide();
                    }
                    else if (userType == "Employee")
                    {
                        // Redirect to Employee form
                        SelectionEmp SelectE = new SelectionEmp();
                        SelectE.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
