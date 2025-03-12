namespace WinFormsApp1
{
    partial class ViewOrganDonor
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            BackButton = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label2 = new Label();
            ViewDonorsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewDonorsGrid).BeginInit();
            SuspendLayout();
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // BackButton
            // 
            BackButton.CustomizableEdges = customizableEdges1;
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
            BackButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BackButton.Size = new Size(180, 45);
            BackButton.TabIndex = 53;
            BackButton.Text = "Go Back <--";
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(737, 11);
            label1.Name = "label1";
            label1.Size = new Size(374, 78);
            label1.TabIndex = 0;
            label1.Text = "BloodBond";
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.FillColor = Color.FromArgb(0, 0, 192);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(192, 0, 0);
            guna2GradientPanel1.Location = new Point(-17, -3);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel1.Size = new Size(1849, 97);
            guna2GradientPanel1.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 27.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(799, 144);
            label2.Name = "label2";
            label2.Size = new Size(143, 44);
            label2.TabIndex = 54;
            label2.Text = "Donors";
            // 
            // ViewDonorsGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ViewDonorsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ViewDonorsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ViewDonorsGrid.ColumnHeadersHeight = 30;
            ViewDonorsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewDonorsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            ViewDonorsGrid.EnableHeadersVisualStyles = true;
            ViewDonorsGrid.GridColor = Color.FromArgb(231, 229, 255);
            ViewDonorsGrid.Location = new Point(106, 276);
            ViewDonorsGrid.Name = "ViewDonorsGrid";
            ViewDonorsGrid.RowHeadersVisible = false;
            ViewDonorsGrid.Size = new Size(1560, 623);
            ViewDonorsGrid.TabIndex = 55;
            ViewDonorsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ViewDonorsGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            ViewDonorsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ViewDonorsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ViewDonorsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ViewDonorsGrid.ThemeStyle.BackColor = Color.White;
            ViewDonorsGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ViewDonorsGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ViewDonorsGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ViewDonorsGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            ViewDonorsGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ViewDonorsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ViewDonorsGrid.ThemeStyle.HeaderStyle.Height = 30;
            ViewDonorsGrid.ThemeStyle.ReadOnly = false;
            ViewDonorsGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            ViewDonorsGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ViewDonorsGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ViewDonorsGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ViewDonorsGrid.ThemeStyle.RowsStyle.Height = 25;
            ViewDonorsGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ViewDonorsGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ViewDonorsGrid.CellContentClick += ViewDonorsGrid_CellContentClick;
            // 
            // ViewOrganDonor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1773, 1042);
            Controls.Add(label2);
            Controls.Add(ViewDonorsGrid);
            Controls.Add(BackButton);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrganDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrganDonor";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewDonorsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView ViewDonorsGrid;
    }
}