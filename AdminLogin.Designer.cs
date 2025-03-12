namespace WinFormsApp1
{
    partial class AdminLogin
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
            AdminPassTb = new TextBox();
            button2 = new Button();
            label3 = new Label();
            GoBack = new Button();
            SuspendLayout();
            // 
            // AdminPassTb
            // 
            AdminPassTb.Location = new Point(336, 273);
            AdminPassTb.Name = "AdminPassTb";
            AdminPassTb.PasswordChar = '$';
            AdminPassTb.Size = new Size(236, 23);
            AdminPassTb.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Century Gothic", 12F);
            button2.Location = new Point(229, 314);
            button2.Name = "button2";
            button2.Size = new Size(343, 35);
            button2.TabIndex = 9;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 274);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // GoBack
            // 
            GoBack.BackColor = SystemColors.ActiveBorder;
            GoBack.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoBack.Location = new Point(12, 576);
            GoBack.Name = "GoBack";
            GoBack.Size = new Size(178, 35);
            GoBack.TabIndex = 12;
            GoBack.Text = "Go Back";
            GoBack.UseVisualStyleBackColor = false;
            GoBack.Click += GoBack_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 623);
            Controls.Add(GoBack);
            Controls.Add(label3);
            Controls.Add(AdminPassTb);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox AdminPassTb;
        private Button button2;
        private Label label3;
        private Button GoBack;
    }
}