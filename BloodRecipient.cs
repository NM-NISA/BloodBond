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
    public partial class BloodRecipient : Form
    {
        public BloodRecipient()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            PopulateComboBoxes();

        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        private void Reset()//field reset kortesi after saving
        {
            RNameTb.Text = "";
            RAddressTb.Text = "";
            RAgeTb.Text = "";
            RPhoneTb.Text = "";
            RGenCb.SelectedIndex = -1;
            RBGroupCB.SelectedIndex = -1;
        }

        private void PopulateComboBoxes()
        {
            // Populate Gender ComboBox
            RGenCb.Items.Add("Male");
            RGenCb.Items.Add("Female");

            // Populate Blood Group ComboBox
            RBGroupCB.Items.Add("A+");
            RBGroupCB.Items.Add("A-");
            RBGroupCB.Items.Add("B+");
            RBGroupCB.Items.Add("B-");
            RBGroupCB.Items.Add("O+");
            RBGroupCB.Items.Add("O-");
            RBGroupCB.Items.Add("AB+");
            RBGroupCB.Items.Add("AB-");
        }

        private void BloodRecipient_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            BloodUserMainForm BloodUMain = new BloodUserMainForm();
            BloodUMain.Show();
            this.Hide();
        }
    }
}
