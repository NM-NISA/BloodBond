using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, EventArgs e)//go back button
        {
            MainMenu MM = new MainMenu();
            MM.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AdminPassTb.Text == "")
            {
                MessageBox.Show("Enter Admin Password pls");
            }
            else if (AdminPassTb.Text == "Project")
            {
                User U = new User();
                U.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WONG PASSWOD");
                AdminPassTb.Text = "";
            }
        }
    }
}
