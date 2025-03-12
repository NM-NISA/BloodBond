﻿using System;
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
    public partial class OrganStock : Form
    {
        public OrganStock()
        {
            InitializeComponent();
            Con = new SqlConnection(connectionString); // Initialize the SqlConnection object
            bloodStock();
        }

        private string connectionString = @"Data Source=DESKTOP-GP448S6\SQLEXPRESS;Initial Catalog=BloodBondDb;Integrated Security=True;";
        private SqlConnection Con;

        private void bloodStock()//For BloodStock grid
        {
            Con.Open();
            string Query = "select * from OrganTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrganStorageGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BloodBankGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OrganEmployeeMainForm OrganEMain = new OrganEmployeeMainForm();
            OrganEMain.Show();
            this.Hide();
        }
    }
}
