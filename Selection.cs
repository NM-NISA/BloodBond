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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)//blood image button
        {
            BloodUserMainForm BloodUMain = new BloodUserMainForm();
            BloodUMain.Show();
            this.Hide();
        }



        private void button4_Click(object sender, EventArgs e)//exit button
        {
            MainMenu MM = new MainMenu();
            MM.Show();
            this.Hide();
        }

        private void OrganSelect_Click(object sender, EventArgs e)
        {
            OrganUserMainForm OUser = new OrganUserMainForm();
            OUser.Show();
            this.Hide();
        }
    }
}
