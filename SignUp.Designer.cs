namespace WinFormsApp1
{
    partial class SignUp
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
            button4 = new Button();
            label3 = new Label();
            label1 = new Label();
            UPassTb = new TextBox();
            UNameTb = new TextBox();
            UserSelection = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            label4 = new Label();
            EmployeeSelection = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            label5 = new Label();
            label6 = new Label();
            SignUpBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label2 = new Label();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(12, 530);
            button4.Name = "button4";
            button4.Size = new Size(115, 42);
            button4.TabIndex = 20;
            button4.Text = "Go Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.Location = new Point(206, 250);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.Location = new Point(206, 197);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 18;
            label1.Text = "User Name";
            // 
            // UPassTb
            // 
            UPassTb.Location = new Point(323, 254);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(236, 23);
            UPassTb.TabIndex = 15;
            // 
            // UNameTb
            // 
            UNameTb.Location = new Point(323, 197);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(236, 23);
            UNameTb.TabIndex = 16;
            // 
            // UserSelection
            // 
            UserSelection.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            UserSelection.CheckedState.BorderThickness = 0;
            UserSelection.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            UserSelection.CheckedState.InnerColor = Color.White;
            UserSelection.Location = new Point(368, 311);
            UserSelection.Name = "UserSelection";
            UserSelection.ShadowDecoration.CustomizableEdges = customizableEdges1;
            UserSelection.Size = new Size(28, 31);
            UserSelection.TabIndex = 21;
            UserSelection.Text = "guna2CustomRadioButton1";
            UserSelection.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            UserSelection.UncheckedState.BorderThickness = 2;
            UserSelection.UncheckedState.FillColor = Color.Transparent;
            UserSelection.UncheckedState.InnerColor = Color.Transparent;
            UserSelection.CheckedChanged += UserSelection_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 311);
            label4.Name = "label4";
            label4.Size = new Size(47, 22);
            label4.TabIndex = 22;
            label4.Text = "User";
            // 
            // EmployeeSelection
            // 
            EmployeeSelection.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmployeeSelection.CheckedState.BorderThickness = 0;
            EmployeeSelection.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            EmployeeSelection.CheckedState.InnerColor = Color.White;
            EmployeeSelection.Location = new Point(521, 311);
            EmployeeSelection.Name = "EmployeeSelection";
            EmployeeSelection.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EmployeeSelection.Size = new Size(28, 31);
            EmployeeSelection.TabIndex = 21;
            EmployeeSelection.Text = "guna2CustomRadioButton1";
            EmployeeSelection.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            EmployeeSelection.UncheckedState.BorderThickness = 2;
            EmployeeSelection.UncheckedState.FillColor = Color.Transparent;
            EmployeeSelection.UncheckedState.InnerColor = Color.Transparent;
            EmployeeSelection.CheckedChanged += EmployeeSelection_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(415, 311);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 22;
            label5.Text = "Employee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(179, 311);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 22;
            label6.Text = "Register as a:";
            // 
            // SignUpBtn
            // 
            SignUpBtn.CustomizableEdges = customizableEdges3;
            SignUpBtn.DisabledState.BorderColor = Color.DarkGray;
            SignUpBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SignUpBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SignUpBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            SignUpBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SignUpBtn.FillColor = Color.Turquoise;
            SignUpBtn.FillColor2 = Color.FromArgb(0, 0, 192);
            SignUpBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            SignUpBtn.Location = new Point(206, 363);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SignUpBtn.Size = new Size(343, 45);
            SignUpBtn.TabIndex = 23;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label2);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.FillColor = Color.FromArgb(0, 0, 192);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(192, 0, 0);
            guna2GradientPanel1.Location = new Point(-9, -1);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(796, 101);
            guna2GradientPanel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(244, 20);
            label2.Name = "label2";
            label2.Size = new Size(280, 58);
            label2.TabIndex = 0;
            label2.Text = "BloodBond";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 584);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(SignUpBtn);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(EmployeeSelection);
            Controls.Add(UserSelection);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(UPassTb);
            Controls.Add(UNameTb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Label label3;
        private Label label1;
        public TextBox UPassTb;
        private TextBox UNameTb;
        private Guna.UI2.WinForms.Guna2CustomRadioButton UserSelection;
        private Label label4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton EmployeeSelection;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2GradientButton SignUpBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label2;
    }
}