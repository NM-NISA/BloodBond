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
    public partial class BloodUserMainForm : Form
    {
        public BloodUserMainForm()
        {
            InitializeComponent();
        }

        private void DonorSelection_Click(object sender, EventArgs e)
        {
            BloodDonor BdonorForm = new BloodDonor();
            BdonorForm.Show();
            this.Hide();
        }

        private void RecipientSelection_Click(object sender, EventArgs e)
        {
            BloodRecipient RecipientForm = new BloodRecipient();
            RecipientForm.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Selection Select = new Selection();
            Select.Show();
            this.Hide();
        }
    }
}
