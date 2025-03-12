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
    public partial class OrganDonate : Form
    {
        public OrganDonate()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            populate();
            populate2();
        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;



        int oldstock;
        private void GetStock(string OrganType)
        {

            Con.Open();
            string query = "select * from OrganTbl where OrganType='" + OrganType + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["OrganStock"].ToString());
            }

            Con.Close();

        }

        private void populate()//For donors' Grid
        {
            Con.Open();
            string Query = "select * from OrganDonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDonorGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populate2()//For OrganStock grid
        {
            Con.Open();
            string Query = "select * from OrganTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BloodStock.DataSource = ds.Tables[0];
            Con.Close();
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            OrganEmployeeMainForm OrganEMain = new OrganEmployeeMainForm();
            OrganEMain.Show();
            this.Hide();
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
                    string query = "update OrganTbl set Organstock=" + stock + "where OrganType='" + BGroupTb.Text + "';";
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
    }
}
