namespace WinFormsApp1
{
    partial class OrganEmployeeMainForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            ViewRecipientSelect = new Guna.UI2.WinForms.Guna2ImageButton();
            ViewDonorsSelect = new Guna.UI2.WinForms.Guna2ImageButton();
            OrganStockSelect = new Guna.UI2.WinForms.Guna2ImageButton();
            TransferSelect = new Guna.UI2.WinForms.Guna2ImageButton();
            label4 = new Label();
            label5 = new Label();
            guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            label6 = new Label();
            BackButton = new Guna.UI2.WinForms.Guna2Button();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.FromArgb(0, 0, 192);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(192, 0, 0);
            guna2GradientPanel1.Location = new Point(-9, -3);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(1832, 94);
            guna2GradientPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(729, 11);
            label1.Name = "label1";
            label1.Size = new Size(374, 78);
            label1.TabIndex = 0;
            label1.Text = "BloodBond";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(571, 486);
            label3.Name = "label3";
            label3.Size = new Size(286, 42);
            label3.TabIndex = 6;
            label3.Text = "View Recipients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(172, 486);
            label2.Name = "label2";
            label2.Size = new Size(229, 42);
            label2.TabIndex = 7;
            label2.Text = "View Donors";
            // 
            // ViewRecipientSelect
            // 
            ViewRecipientSelect.CheckedState.ImageSize = new Size(64, 64);
            ViewRecipientSelect.HoverState.ImageSize = new Size(239, 239);
            ViewRecipientSelect.Image = Properties.Resources.Recipient_logo;
            ViewRecipientSelect.ImageOffset = new Point(0, 0);
            ViewRecipientSelect.ImageRotate = 0F;
            ViewRecipientSelect.ImageSize = new Size(239, 239);
            ViewRecipientSelect.Location = new Point(595, 218);
            ViewRecipientSelect.Name = "ViewRecipientSelect";
            ViewRecipientSelect.PressedState.ImageSize = new Size(64, 64);
            ViewRecipientSelect.ShadowDecoration.CustomizableEdges = customizableEdges3;
            ViewRecipientSelect.Size = new Size(239, 239);
            ViewRecipientSelect.TabIndex = 4;
            ViewRecipientSelect.Click += ViewRecipientSelect_Click;
            // 
            // ViewDonorsSelect
            // 
            ViewDonorsSelect.CheckedState.ImageSize = new Size(64, 64);
            ViewDonorsSelect.HoverState.ImageSize = new Size(239, 239);
            ViewDonorsSelect.Image = Properties.Resources.Donor_logo;
            ViewDonorsSelect.ImageOffset = new Point(0, 0);
            ViewDonorsSelect.ImageRotate = 0F;
            ViewDonorsSelect.ImageSize = new Size(239, 239);
            ViewDonorsSelect.Location = new Point(167, 218);
            ViewDonorsSelect.Name = "ViewDonorsSelect";
            ViewDonorsSelect.PressedState.ImageSize = new Size(64, 64);
            ViewDonorsSelect.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ViewDonorsSelect.Size = new Size(239, 239);
            ViewDonorsSelect.TabIndex = 5;
            ViewDonorsSelect.Click += ViewDonorsSelect_Click;
            // 
            // OrganStockSelect
            // 
            OrganStockSelect.CheckedState.ImageSize = new Size(64, 64);
            OrganStockSelect.HoverState.ImageSize = new Size(239, 239);
            OrganStockSelect.Image = Properties.Resources.Organ_logo;
            OrganStockSelect.ImageOffset = new Point(0, 0);
            OrganStockSelect.ImageRotate = 0F;
            OrganStockSelect.ImageSize = new Size(239, 239);
            OrganStockSelect.Location = new Point(1023, 218);
            OrganStockSelect.Name = "OrganStockSelect";
            OrganStockSelect.PressedState.ImageSize = new Size(64, 64);
            OrganStockSelect.ShadowDecoration.CustomizableEdges = customizableEdges5;
            OrganStockSelect.Size = new Size(239, 239);
            OrganStockSelect.TabIndex = 5;
            OrganStockSelect.Click += OrganStockSelect_Click;
            // 
            // TransferSelect
            // 
            TransferSelect.CheckedState.ImageSize = new Size(64, 64);
            TransferSelect.HoverState.ImageSize = new Size(239, 239);
            TransferSelect.Image = Properties.Resources.Organ_transfer_logo;
            TransferSelect.ImageOffset = new Point(0, 0);
            TransferSelect.ImageRotate = 0F;
            TransferSelect.ImageSize = new Size(239, 239);
            TransferSelect.Location = new Point(1383, 218);
            TransferSelect.Name = "TransferSelect";
            TransferSelect.PressedState.ImageSize = new Size(64, 64);
            TransferSelect.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TransferSelect.Size = new Size(239, 239);
            TransferSelect.TabIndex = 4;
            TransferSelect.Click += TransferSelect_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1027, 486);
            label4.Name = "label4";
            label4.Size = new Size(231, 42);
            label4.TabIndex = 7;
            label4.Text = "Organ Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1428, 486);
            label5.Name = "label5";
            label5.Size = new Size(148, 42);
            label5.TabIndex = 6;
            label5.Text = "Transfer";
            // 
            // guna2ImageButton5
            // 
            guna2ImageButton5.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton5.HoverState.ImageSize = new Size(239, 239);
            guna2ImageButton5.Image = Properties.Resources.Dashboard_logo;
            guna2ImageButton5.ImageOffset = new Point(0, 0);
            guna2ImageButton5.ImageRotate = 0F;
            guna2ImageButton5.ImageSize = new Size(239, 239);
            guna2ImageButton5.Location = new Point(775, 686);
            guna2ImageButton5.Name = "guna2ImageButton5";
            guna2ImageButton5.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton5.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2ImageButton5.Size = new Size(239, 239);
            guna2ImageButton5.TabIndex = 4;
            guna2ImageButton5.Click += guna2ImageButton5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(790, 944);
            label6.Name = "label6";
            label6.Size = new Size(209, 42);
            label6.TabIndex = 6;
            label6.Text = "Dashboard";
            // 
            // BackButton
            // 
            BackButton.CustomizableEdges = customizableEdges8;
            BackButton.DisabledState.BorderColor = Color.DarkGray;
            BackButton.DisabledState.CustomBorderColor = Color.DarkGray;
            BackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BackButton.FillColor = Color.FromArgb(192, 0, 0);
            BackButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.White;
            BackButton.HoverState.BorderColor = Color.Red;
            BackButton.Location = new Point(12, 1024);
            BackButton.Name = "BackButton";
            BackButton.ShadowDecoration.CustomizableEdges = customizableEdges9;
            BackButton.Size = new Size(180, 45);
            BackButton.TabIndex = 20;
            BackButton.Text = "Go Back <--";
            BackButton.Click += BackButton_Click;
            // 
            // OrganEmployeeMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1789, 1081);
            Controls.Add(BackButton);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(guna2ImageButton5);
            Controls.Add(TransferSelect);
            Controls.Add(OrganStockSelect);
            Controls.Add(ViewRecipientSelect);
            Controls.Add(ViewDonorsSelect);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrganEmployeeMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrganEmployeeMainForm";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton ViewRecipientSelect;
        private Guna.UI2.WinForms.Guna2ImageButton ViewDonorsSelect;
        private Guna.UI2.WinForms.Guna2ImageButton OrganStockSelect;
        private Guna.UI2.WinForms.Guna2ImageButton TransferSelect;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button BackButton;
    }
}