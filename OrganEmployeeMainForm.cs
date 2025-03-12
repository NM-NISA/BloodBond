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
    public partial class OrganEmployeeMainForm : Form
    {
        public OrganEmployeeMainForm()
        {
            InitializeComponent();
        }

        private void ViewRecipientSelect_Click(object sender, EventArgs e)
        {
            ViewOrganRecipient ViewORec = new ViewOrganRecipient();
            ViewORec.Show();
            this.Hide();
        }

        private void ViewDonorsSelect_Click(object sender, EventArgs e)
        {
            ViewOrganDonor ViewODonor = new ViewOrganDonor();
            ViewODonor.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SelectionEmp ESelect = new SelectionEmp();
            ESelect.Show();
            this.Hide();
        }

        private void OrganStockSelect_Click(object sender, EventArgs e)
        {
            OrganStock OStock = new OrganStock();
            OStock.Show();
            this.Hide();
        }

        private void TransferSelect_Click(object sender, EventArgs e)
        {
            OrganTransfer OTrans = new OrganTransfer();
            OTrans.Show();
            this.Hide();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            OrganDashboard ODash = new OrganDashboard();
            ODash.Show();
            this.Hide();
        }
    }
}
