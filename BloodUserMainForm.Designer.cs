﻿namespace WinFormsApp1
{
    partial class BloodUserMainForm
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
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            RecipientRegLbl = new Label();
            DonorRegLbl = new Label();
            RecipientSelection = new Guna.UI2.WinForms.Guna2ImageButton();
            DonorSelection = new Guna.UI2.WinForms.Guna2ImageButton();
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
            guna2GradientPanel1.Location = new Point(-8, -5);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(1820, 102);
            guna2GradientPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(723, 11);
            label1.Name = "label1";
            label1.Size = new Size(374, 78);
            label1.TabIndex = 0;
            label1.Text = "BloodBond";
            // 
            // RecipientRegLbl
            // 
            RecipientRegLbl.AutoSize = true;
            RecipientRegLbl.BackColor = Color.Transparent;
            RecipientRegLbl.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecipientRegLbl.ForeColor = SystemColors.ActiveCaptionText;
            RecipientRegLbl.Location = new Point(937, 663);
            RecipientRegLbl.Name = "RecipientRegLbl";
            RecipientRegLbl.Size = new Size(388, 42);
            RecipientRegLbl.TabIndex = 6;
            RecipientRegLbl.Text = "Recipient Registration";
            // 
            // DonorRegLbl
            // 
            DonorRegLbl.AutoSize = true;
            DonorRegLbl.BackColor = Color.Transparent;
            DonorRegLbl.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonorRegLbl.ForeColor = SystemColors.ActiveCaptionText;
            DonorRegLbl.Location = new Point(464, 663);
            DonorRegLbl.Name = "DonorRegLbl";
            DonorRegLbl.Size = new Size(331, 42);
            DonorRegLbl.TabIndex = 7;
            DonorRegLbl.Text = "Donor Registration";
            // 
            // RecipientSelection
            // 
            RecipientSelection.CheckedState.ImageSize = new Size(64, 64);
            RecipientSelection.HoverState.ImageSize = new Size(64, 64);
            RecipientSelection.Image = Properties.Resources.Registration_logo_2;
            RecipientSelection.ImageOffset = new Point(0, 0);
            RecipientSelection.ImageRotate = 0F;
            RecipientSelection.ImageSize = new Size(239, 239);
            RecipientSelection.Location = new Point(1012, 375);
            RecipientSelection.Name = "RecipientSelection";
            RecipientSelection.PressedState.ImageSize = new Size(64, 64);
            RecipientSelection.ShadowDecoration.CustomizableEdges = customizableEdges3;
            RecipientSelection.Size = new Size(239, 239);
            RecipientSelection.TabIndex = 4;
            RecipientSelection.Click += RecipientSelection_Click;
            // 
            // DonorSelection
            // 
            DonorSelection.CheckedState.ImageSize = new Size(64, 64);
            DonorSelection.HoverState.ImageSize = new Size(64, 64);
            DonorSelection.Image = Properties.Resources.Registration_logo;
            DonorSelection.ImageOffset = new Point(0, 0);
            DonorSelection.ImageRotate = 0F;
            DonorSelection.ImageSize = new Size(239, 239);
            DonorSelection.Location = new Point(510, 375);
            DonorSelection.Name = "DonorSelection";
            DonorSelection.PressedState.ImageSize = new Size(64, 64);
            DonorSelection.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DonorSelection.Size = new Size(239, 239);
            DonorSelection.TabIndex = 5;
            DonorSelection.Click += DonorSelection_Click;
            // 
            // BackButton
            // 
            BackButton.CustomizableEdges = customizableEdges5;
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
            BackButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BackButton.Size = new Size(180, 45);
            BackButton.TabIndex = 20;
            BackButton.Text = "Go Back <--";
            BackButton.Click += BackButton_Click;
            // 
            // BloodUserMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1789, 1081);
            Controls.Add(BackButton);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(RecipientRegLbl);
            Controls.Add(DonorRegLbl);
            Controls.Add(RecipientSelection);
            Controls.Add(DonorSelection);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BloodUserMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodUserMainForm";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Label RecipientRegLbl;
        private Label DonorRegLbl;
        private Guna.UI2.WinForms.Guna2ImageButton RecipientSelection;
        private Guna.UI2.WinForms.Guna2ImageButton DonorSelection;
        private Guna.UI2.WinForms.Guna2Button BackButton;
    }
}