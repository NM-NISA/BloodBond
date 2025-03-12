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
    public partial class BloodEmployeeMainForm : Form
    {
        public BloodEmployeeMainForm()
        {
            InitializeComponent();
        }

        private void ViewDonorsSelect_Click(object sender, EventArgs e)
        {
            ViewBloodDonors viewDonorsForm = new ViewBloodDonors();
            viewDonorsForm.Show();
            this.Hide();
        }

        private void ViewRecipientSelect_Click(object sender, EventArgs e)
        {
            ViewBloodRecipient viewRecipientsForm = new ViewBloodRecipient();
            viewRecipientsForm.Show();
            this.Hide();
        }

        private void BloodBankSelect_Click(object sender, EventArgs e)
        {
            BloodBank BloodB = new BloodBank();
            BloodB.Show();
            this.Hide();
        }

        private void TransferSelect_Click(object sender, EventArgs e)
        {
            BloodTransfer BTransferForm = new BloodTransfer();
            BTransferForm.Show();
            this.Hide();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            Dashboard Dash = new Dashboard();
            Dash.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SelectionEmp SelectE = new SelectionEmp();
            SelectE.Show();
            this.Hide();
        }

        private void BloodEmployeeMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
