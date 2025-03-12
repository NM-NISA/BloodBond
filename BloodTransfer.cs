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
    public partial class BloodTransfer : Form
    {
        public BloodTransfer()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            fillRecipientCb();
            AvailableLabel.Visible = false;
            RecipientIdCb.SelectedIndex = -1;

        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;


        int stock = 0;
        private void fillRecipientCb()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select RNum from RecipientTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RNum", typeof(int));
            dt.Load(rdr);
            RecipientIdCb.ValueMember = "RNum";
            RecipientIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetData() //used to get the bloodgroup and name of the recipient
        {

            Con.Open();
            string query = "select * from RecipientTBL where RNum=" + RecipientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                RecipientNameTb.Text = dr["RName"].ToString();
                BloodGroup.Text = dr["RGroup"].ToString();
            }

            Con.Close();

        }


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
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }

            Con.Close();

        }

        private void RecipientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BloodGroup.Text);
            if (stock > 0)
            {
                TransferButton.Visible = true;
                AvailableLabel.Text = "Blood stock is available :D";
                AvailableLabel.ForeColor = Color.Green;
                AvailableLabel.TextAlign = ContentAlignment.MiddleCenter;

                AvailableLabel.Visible = true;
            }
            else
            {
                TransferButton.Visible = false;
                AvailableLabel.Text = "Blood stock is not available :(";
                AvailableLabel.ForeColor = Color.Red;
                AvailableLabel.TextAlign = ContentAlignment.MiddleCenter;
                AvailableLabel.Visible = true;
            }
        }

        private void Reset()
        {
            RecipientNameTb.Text = "";
            RecipientIdCb.SelectedIndex = -1;
            BloodGroup.Text = "";
            AvailableLabel.Visible = false;
            TransferButton.Visible = false;
        }

        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {
                string query = "update BloodTbl set Bstock=" + newstock + "Where BGroup='" + BloodGroup.Text + "';";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (RecipientNameTb.Text == "")
            {
                MessageBox.Show("Missing Info");
            }

            else
            {
                try
                {
                    string query = "insert into BloodTransferTbl values ('" + RecipientNameTb.Text + "', '" + BloodGroup.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transfer Successful");
                    Con.Close();
                    GetStock(BloodGroup.Text);
                    updateStock();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void BloodTransfer_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BloodEmployeeMainForm BloodEMain = new BloodEmployeeMainForm();
            BloodEMain.Show();
            this.Hide();
        }

        private void Go2BDonateBtn_Click(object sender, EventArgs e)
        {
            BloodDonate BDonate = new BloodDonate();
            BDonate.Show();
            this.Hide();
        }
    }
}
