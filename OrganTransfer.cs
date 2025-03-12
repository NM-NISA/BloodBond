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
    public partial class OrganTransfer : Form
    {
        public OrganTransfer()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            fillRecipientCb();
            AvailableLabel.Visible = false;
            OrganRecipientIdCb.SelectedIndex = -1;
        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        int stock = 0;
        private void fillRecipientCb()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select RNum from OrganRecipientTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RNum", typeof(int));
            dt.Load(rdr);
            OrganRecipientIdCb.ValueMember = "RNum";
            OrganRecipientIdCb.DataSource = dt;
            Con.Close();
        }

        private void GetData() //used to get the bloodgroup and name of the recipient
        {

            Con.Open();
            string query = "select * from OrganRecipientTBL where RNum=" + OrganRecipientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                OrganRecipientNameTb.Text = dr["RName"].ToString();
                OrganType.Text = dr["ROrgan"].ToString();
            }

            Con.Close();

        }

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
                stock = Convert.ToInt32(dr["OrganStock"].ToString());
            }

            Con.Close();

        }

        private void RecipientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(OrganType.Text);
            if (stock > 0)
            {
                TransferButton.Visible = true;
                AvailableLabel.Text = "Organ is available :D";
                AvailableLabel.ForeColor = Color.Green;
                AvailableLabel.TextAlign = ContentAlignment.MiddleCenter;

                AvailableLabel.Visible = true;
            }
            else
            {
                TransferButton.Visible = false;
                AvailableLabel.Text = "Organ is not available :(";
                AvailableLabel.ForeColor = Color.Red;
                AvailableLabel.TextAlign = ContentAlignment.MiddleCenter;
                AvailableLabel.Visible = true;
            }
        }

        private void Reset()
        {
            OrganRecipientNameTb.Text = "";
            OrganRecipientIdCb.SelectedIndex = -1;
            OrganType.Text = "";
            AvailableLabel.Visible = false;
            TransferButton.Visible = false;
        }

        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {
                string query = "update OrganTbl set Organstock=" + newstock + "Where OrganType='" + OrganType.Text + "';";
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


        private void OrganTransfer_Load(object sender, EventArgs e)
        {

        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (OrganRecipientNameTb.Text == "")
            {
                MessageBox.Show("Missing Info");
            }

            else
            {
                try
                {
                    string query = "insert into OrganTransferTbl values ('" + OrganRecipientNameTb.Text + "', '" + OrganType.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transfer Successful");
                    Con.Close();
                    GetStock(OrganType.Text);
                    updateStock();
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
            OrganEmployeeMainForm OrganEMain = new OrganEmployeeMainForm();
            OrganEMain.Show();
            this.Hide();
        }

        private void Go2BDonateBtn_Click(object sender, EventArgs e)
        {
            OrganDonate ODonate = new OrganDonate();
            ODonate.Show();
            this.Hide();
        }
    }
}
