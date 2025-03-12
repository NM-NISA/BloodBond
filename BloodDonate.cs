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
    public partial class BloodDonate : Form
    {
        public BloodDonate()
        {
            InitializeComponent(); 
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            populate();
            populate2();
        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        int oldstock;
        private void GetStock(string BGroup)
        {

            Con.Open();
            string query = "select * from BloodTbl where BGroup='" + BGroup + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());
            }

            Con.Close();

        }

        private void populate()//For donors' Grid
        {
            Con.Open();
            string Query = "select * from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDonorGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populate2()//For BloodStock grid
        {
            Con.Open();
            string Query = "select * from BloodTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BloodStock.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BloodStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewDonorGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = ViewDonorGrid.SelectedRows[0].Cells[1].Value.ToString();
            BGroupTb.Text = ViewDonorGrid.SelectedRows[0].Cells[6].Value.ToString();
            GetStock(BGroupTb.Text);
        }

        private void Reset()
        {
            DNameTb.Text = "";
            BGroupTb.Text = "";

        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "")
            {
                MessageBox.Show("Select a Donor");
            }
            else
            {
                try
                {
                    int stock = oldstock + 1;
                    string query = "update BloodTbl set Bstock=" + stock + "where BGroup='" + BGroupTb.Text + "';";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Successfully");
                    Con.Close();
                    Reset();
                    populate2();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BloodEmployeeMainForm BloodEMain = new BloodEmployeeMainForm();
            BloodEMain.Show();
            this.Hide();
        }

        private void Go2BTransferBtn_Click(object sender, EventArgs e)
        {
            BloodTransfer BTransfer = new BloodTransfer();
            BTransfer.Show();
            this.Hide();
        }
    }
}
