using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            GetData();
            

        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        private void GetData()
        {
            try
            {
                Con.Open();

                // Fetch general statistics
                DonorLbl.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM DonorTbl");
                TransferLbl.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM BloodTransferTbl");
                UserLbl.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM UserTbl");

                // Calculate total blood stock
                string totalStockQuery = "SELECT SUM(BStock) FROM BloodTbl";
                string totalStockResult = ExecuteScalarQuery(totalStockQuery);
                int totalStock = string.IsNullOrEmpty(totalStockResult) ? 0 : Convert.ToInt32(totalStockResult);
                TotalLbl.Text = totalStock.ToString();
                TotalLbl.TextAlign = ContentAlignment.MiddleCenter;

                // Blood groups data
                UpdateBloodGroupStats("O+", OPosNum, OPosProgress, totalStock);
                UpdateBloodGroupStats("AB+", ABPosNum, ABPosProgress, totalStock);
                UpdateBloodGroupStats("B+", BPosNum, BPosProgress, totalStock);
                UpdateBloodGroupStats("A+", APosNum, APosProgress, totalStock);
                UpdateBloodGroupStats("A-", ANegNum, ANegProgress, totalStock);
                UpdateBloodGroupStats("B-", BNegNum, BNegProgress, totalStock);
                UpdateBloodGroupStats("O-", ONegNum, ONegProgress, totalStock);
                UpdateBloodGroupStats("AB-", ABNegNum, ABNegProgress, totalStock);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

        private string ExecuteScalarQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Con);
            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : string.Empty;
        }

        private void UpdateBloodGroupStats(string bloodGroup, Label countLabel, Guna.UI2.WinForms.Guna2CircleProgressBar progressBar, int totalStock)
        {
            try
            {
                string query = $"SELECT BStock FROM BloodTbl WHERE BGroup = '{bloodGroup}'";
                string stockResult = ExecuteScalarQuery(query);
                int stock = string.IsNullOrEmpty(stockResult) ? 0 : Convert.ToInt32(stockResult);

                // Update label and progress bar
                countLabel.Text = stock.ToString();
                double percentage = totalStock > 0 ? (stock / (double)totalStock) * 100 : 0;
                progressBar.Value = Convert.ToInt32(percentage);
                progressBar.Text = $"{Convert.ToInt32(percentage)}%"; // Display percentage in the circle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating stats for {bloodGroup}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Any specific actions on load can go here
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BloodEmployeeMainForm BloodEMain = new BloodEmployeeMainForm();
            BloodEMain.Show();
            this.Hide();
        }

        private void TransferLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
