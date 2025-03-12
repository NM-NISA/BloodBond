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
    public partial class OrganDashboard : Form
    {
        public OrganDashboard()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            GetData();
        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        private string ExecuteScalarQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Con);
            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : string.Empty;
        }

        private void GetData()
        {
            try
            {
                Con.Open();

                // Fetch general statistics
                DonorLbl.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM OrganDonorTbl");
                TransferLbl.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM OrganTransferTbl");
                UserLbl.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM UserTbl");

                // Calculate total blood stock
                string totalStockQuery = "SELECT SUM(OrganStock) FROM OrganTbl";
                string totalStockResult = ExecuteScalarQuery(totalStockQuery);
                int totalStock = string.IsNullOrEmpty(totalStockResult) ? 0 : Convert.ToInt32(totalStockResult);
                TotalLbl.Text = totalStock.ToString();
                TotalLbl.TextAlign = ContentAlignment.MiddleCenter;

                // Blood groups data
                UpdateBloodGroupStats("Bone Marrow", BoneMNum, BoneMProgress, totalStock);
                UpdateBloodGroupStats("Eyes", EyesNum, EyesProgress, totalStock);
                UpdateBloodGroupStats("Heart", HeartNum, HeartProgress, totalStock);
                UpdateBloodGroupStats("Intestines", IntNum, IntProgress, totalStock);
                UpdateBloodGroupStats("Kidney", KidneyNum, KidneyProgress, totalStock);
                UpdateBloodGroupStats("Pancreas", PanNum, PancProgress, totalStock);
                UpdateBloodGroupStats("Liver", LiverNum, LiverProgress, totalStock);
                UpdateBloodGroupStats("Lungs", LungsNum, LungsProgress, totalStock);

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

        private void UpdateBloodGroupStats(string organType, Label countLabel, Guna.UI2.WinForms.Guna2CircleProgressBar progressBar, int totalStock)
        {
            try
            {
                string query = $"SELECT OrganStock FROM OrganTbl WHERE OrganType = '{organType}'";
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
                MessageBox.Show($"Error updating stats for {organType}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
