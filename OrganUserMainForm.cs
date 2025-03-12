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
    public partial class OrganUserMainForm : Form
    {
        public OrganUserMainForm()
        {
            InitializeComponent();
        }

        private void RecipientSelection_Click(object sender, EventArgs e)
        {
            OrganRecipient ORec = new OrganRecipient();
            ORec.Show();
            this.Hide();
        }

        private void DonorSelection_Click(object sender, EventArgs e)
        {
            OrganDonor ODonor = new OrganDonor();
            ODonor.Show();
            this.Hide();
        }
    }
}
