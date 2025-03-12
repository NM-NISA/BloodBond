namespace WinFormsApp1
{
    partial class OrganStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            label4 = new Label();
            BackButton = new Guna.UI2.WinForms.Guna2Button();
            OrganStorageGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrganStorageGrid).BeginInit();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.FromArgb(0, 0, 192);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(192, 0, 0);
            guna2GradientPanel1.Location = new Point(-31, -6);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(1863, 101);
            guna2GradientPanel1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(744, 11);
            label1.Name = "label1";
            label1.Size = new Size(374, 78);
            label1.TabIndex = 0;
            label1.Text = "BloodBond";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(750, 176);
            label4.Name = "label4";
            label4.Size = new Size(272, 42);
            label4.TabIndex = 26;
            label4.Text = "Organ Storage";
            // 
            // BackButton
            // 
            BackButton.CustomizableEdges = customizableEdges3;
            BackButton.DisabledState.BorderColor = Color.DarkGray;
            BackButton.DisabledState.CustomBorderColor = Color.DarkGray;
            BackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BackButton.FillColor = Color.FromArgb(192, 0, 0);
            BackButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.White;
            BackButton.HoverState.BorderColor = Color.Red;
            BackButton.Location = new Point(12, 985);
            BackButton.Name = "BackButton";
            BackButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BackButton.Size = new Size(180, 45);
            BackButton.TabIndex = 25;
            BackButton.Text = "Go Back <--";
            BackButton.Click += BackButton_Click;
            // 
            // OrganStorageGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            OrganStorageGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            OrganStorageGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            OrganStorageGrid.ColumnHeadersHeight = 25;
            OrganStorageGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            OrganStorageGrid.DefaultCellStyle = dataGridViewCellStyle3;
            OrganStorageGrid.GridColor = Color.FromArgb(231, 229, 255);
            OrganStorageGrid.Location = new Point(232, 366);
            OrganStorageGrid.Name = "OrganStorageGrid";
            OrganStorageGrid.RowHeadersVisible = false;
            OrganStorageGrid.Size = new Size(1305, 564);
            OrganStorageGrid.TabIndex = 24;
            OrganStorageGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OrganStorageGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            OrganStorageGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OrganStorageGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OrganStorageGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OrganStorageGrid.ThemeStyle.BackColor = Color.White;
            OrganStorageGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OrganStorageGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            OrganStorageGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OrganStorageGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            OrganStorageGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OrganStorageGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            OrganStorageGrid.ThemeStyle.HeaderStyle.Height = 25;
            OrganStorageGrid.ThemeStyle.ReadOnly = false;
            OrganStorageGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            OrganStorageGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrganStorageGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            OrganStorageGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            OrganStorageGrid.ThemeStyle.RowsStyle.Height = 25;
            OrganStorageGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            OrganStorageGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            OrganStorageGrid.CellContentClick += BloodBankGrid_CellContentClick;
            // 
            // OrganStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1773, 1042);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(label4);
            Controls.Add(BackButton);
            Controls.Add(OrganStorageGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrganStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrganStock";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrganStorageGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI2.WinForms.Guna2DataGridView OrganStorageGrid;
    }
}