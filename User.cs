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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            populate();
        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;


        private void label9_Click(object sender, EventArgs e)
        {
            MainMenu MainM = new MainMenu();
            MainM.Show();
            this.Hide();
        }

        private void Reset()
        {
            UNameTb.Text = "";
            UPassTb.Text = "";
            key = 0;
        }

        private void populate()
        {
            Con.Open();
            string Query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)//for the save button
        {
            if (UNameTb.Text == "" || UPassTb.Text == "")
            {
                MessageBox.Show("Missing Info");
            }

            else
            {
                try
                {
                    string query = "insert into UserTbl values ('" + UNameTb.Text + "', '" + UPassTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Saved");
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;

        private void ViewDonorGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UNameTb.Text = UsersGrid.SelectedRows[0].Cells[1].Value.ToString();
            UPassTb.Text = UsersGrid.SelectedRows[0].Cells[2].Value.ToString();

            if (UNameTb.Text == "")
            {
                key = 0;
            }
            else
            {

                key = Convert.ToInt32(UsersGrid.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)//delete button er jonno
        {
            if (key == 0)
            {
                MessageBox.Show("Select User to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from UserTbl where UserNum=" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Dilited");
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//edit button er jonno
        {
            if (UNameTb.Text == "" || UPassTb.Text == "")
            {
                MessageBox.Show("Info missin");
            }
            else
            {
                try
                {
                    string query = "update UserTbl set UserID='" + UNameTb.Text + "',UserPass='" + UPassTb.Text + "'where UserNum=" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated");
                    Con.Close();
                    Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
