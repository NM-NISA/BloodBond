namespace WinFormsApp1
{
    partial class User
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
            UsersGrid = new DataGridView();
            UPassTb = new TextBox();
            panel1 = new Panel();
            panel10 = new Panel();
            label9 = new Label();
            label17 = new Label();
            button2 = new Button();
            label16 = new Label();
            label11 = new Label();
            UNameTb = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)UsersGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // UsersGrid
            // 
            UsersGrid.AllowUserToAddRows = false;
            UsersGrid.AllowUserToDeleteRows = false;
            UsersGrid.AllowUserToResizeColumns = false;
            UsersGrid.AllowUserToResizeRows = false;
            UsersGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UsersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGrid.BackgroundColor = Color.Beige;
            UsersGrid.BorderStyle = BorderStyle.None;
            UsersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGrid.Location = new Point(587, 297);
            UsersGrid.Name = "UsersGrid";
            UsersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGrid.Size = new Size(872, 374);
            UsersGrid.TabIndex = 43;
            UsersGrid.CellClick += ViewDonorGrid_CellContentClick;
            UsersGrid.CellContentClick += ViewDonorGrid_CellContentClick;
            // 
            // UPassTb
            // 
            UPassTb.Font = new Font("Times New Roman", 14.25F);
            UPassTb.Location = new Point(1231, 869);
            UPassTb.Name = "UPassTb";
            UPassTb.Size = new Size(344, 29);
            UPassTb.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 75, 75);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 1085);
            panel1.TabIndex = 34;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Gold;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Font = new Font("Times New Roman", 26.25F);
            panel10.Location = new Point(91, 179);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 52);
            panel10.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(75, 75, 75);
            label9.Font = new Font("Times New Roman", 26.25F);
            label9.ForeColor = SystemColors.MenuBar;
            label9.Location = new Point(12, 1034);
            label9.Name = "label9";
            label9.Size = new Size(117, 40);
            label9.TabIndex = 10;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(75, 75, 75);
            label17.Font = new Font("Times New Roman", 26.25F, FontStyle.Underline);
            label17.ForeColor = Color.Gold;
            label17.Location = new Point(107, 179);
            label17.Name = "label17";
            label17.Size = new Size(96, 40);
            label17.TabIndex = 10;
            label17.Text = "Users";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Century Gothic", 12F);
            button2.Location = new Point(587, 939);
            button2.Name = "button2";
            button2.Size = new Size(202, 63);
            button2.TabIndex = 42;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Beige;
            label16.Font = new Font("Georgia", 27.75F);
            label16.ForeColor = SystemColors.InactiveCaptionText;
            label16.Location = new Point(1231, 820);
            label16.Name = "label16";
            label16.Size = new Size(176, 43);
            label16.TabIndex = 40;
            label16.Text = "Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Beige;
            label11.Font = new Font("Georgia", 27.75F);
            label11.ForeColor = SystemColors.InactiveCaptionText;
            label11.Location = new Point(587, 820);
            label11.Name = "label11";
            label11.Size = new Size(117, 43);
            label11.TabIndex = 41;
            label11.Text = "Name";
            // 
            // UNameTb
            // 
            UNameTb.Font = new Font("Times New Roman", 14.25F);
            UNameTb.Location = new Point(587, 866);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(245, 29);
            UNameTb.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Maroon;
            label2.Font = new Font("Georgia", 27.75F);
            label2.ForeColor = SystemColors.MenuBar;
            label2.Location = new Point(667, 19);
            label2.Name = "label2";
            label2.Size = new Size(202, 43);
            label2.TabIndex = 9;
            label2.Text = "BloodBond";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(251, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1538, 85);
            panel2.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Beige;
            label10.Font = new Font("Georgia", 27.75F, FontStyle.Underline);
            label10.ForeColor = SystemColors.InactiveCaptionText;
            label10.Location = new Point(959, 106);
            label10.Name = "label10";
            label10.Size = new Size(112, 43);
            label10.TabIndex = 37;
            label10.Text = "Users";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Century Gothic", 12F);
            button1.Location = new Point(918, 939);
            button1.Name = "button1";
            button1.Size = new Size(202, 63);
            button1.TabIndex = 44;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Century Gothic", 12F);
            button3.Location = new Point(1257, 939);
            button3.Name = "button3";
            button3.Size = new Size(202, 63);
            button3.TabIndex = 45;
            button3.Text = "Dilit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1789, 1081);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(UsersGrid);
            Controls.Add(UPassTb);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(UNameTb);
            Controls.Add(panel2);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)UsersGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UsersGrid;
        private TextBox UPassTb;
        private Panel panel1;
        private Panel panel10;
        private Label label9;
        private Label label17;
        private Button button2;
        private Label label16;
        private Label label11;
        private TextBox UNameTb;
        private Label label2;
        private Panel panel2;
        private Label label10;
        private Button button1;
        private Button button3;
    }
}