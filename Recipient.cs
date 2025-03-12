using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Recipient : Form
    {
        public Recipient()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True");

        private void Reset()//field reset kortesi after saving
        {
            RNameTb.Text = "";
            RAddressTb.Text = "";
            RAgeTb.Text = "";
            RPhoneTb.Text = "";
            RGenCb.SelectedIndex = -1;
            RBGroupCB.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Recipient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Save button
        {
            if (RNameTb.Text == "" || RPhoneTb.Text == "" || RGenCb.SelectedIndex == -1 || RBGroupCB.SelectedIndex == -1 || RAddressTb.Text == "")
            {
                MessageBox.Show("Missing Info");
            }

            else
            {
                try
                {
                    string query = "insert into RecipientTbl values ('" + RNameTb.Text + "', " + RAgeTb.Text + ",'" + RGenCb.SelectedItem.ToString() + "', '" + RPhoneTb.Text + "','" + RAddressTb.Text + "','" + RBGroupCB.SelectedItem.ToString() + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Recipient Successfully Registered");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
     

        private void label9_Click(object sender, EventArgs e)
        {
            MainMenu MM = new MainMenu();
            MM.Show();
            this.Hide();
        }
    }
}
