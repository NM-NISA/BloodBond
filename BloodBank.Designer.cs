namespace WinFormsApp1
{
    partial class BloodBank
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            BloodBankGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            BackButton = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BloodBankGrid).BeginInit();
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
            guna2GradientPanel1.TabIndex = 1;
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
            // BloodBankGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            BloodBankGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BloodBankGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BloodBankGrid.ColumnHeadersHeight = 25;
            BloodBankGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BloodBankGrid.DefaultCellStyle = dataGridViewCellStyle3;
            BloodBankGrid.GridColor = Color.FromArgb(231, 229, 255);
            BloodBankGrid.Location = new Point(232, 366);
            BloodBankGrid.Name = "BloodBankGrid";
            BloodBankGrid.RowHeadersVisible = false;
            BloodBankGrid.Size = new Size(1305, 564);
            BloodBankGrid.TabIndex = 2;
            BloodBankGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BloodBankGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            BloodBankGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BloodBankGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BloodBankGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BloodBankGrid.ThemeStyle.BackColor = Color.White;
            BloodBankGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BloodBankGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            BloodBankGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BloodBankGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            BloodBankGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BloodBankGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BloodBankGrid.ThemeStyle.HeaderStyle.Height = 25;
            BloodBankGrid.ThemeStyle.ReadOnly = false;
            BloodBankGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            BloodBankGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BloodBankGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            BloodBankGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BloodBankGrid.ThemeStyle.RowsStyle.Height = 25;
            BloodBankGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BloodBankGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            BloodBankGrid.CellContentClick += BloodBankGrid_CellContentClick;
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
            BackButton.TabIndex = 21;
            BackButton.Text = "Go Back <--";
            BackButton.Click += BackButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(783, 176);
            label4.Name = "label4";
            label4.Size = new Size(207, 42);
            label4.TabIndex = 22;
            label4.Text = "Blood Bank";
            // 
            // BloodBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1773, 1042);
            Controls.Add(label4);
            Controls.Add(BackButton);
            Controls.Add(BloodBankGrid);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BloodBank";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodBank";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BloodBankGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView BloodBankGrid;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Label label4;
    }
}