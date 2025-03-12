namespace WinFormsApp1
{
    partial class SelectionEmp
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
            OrganSelect = new Guna.UI2.WinForms.Guna2ImageButton();
            BloodSelect = new Guna.UI2.WinForms.Guna2ImageButton();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // OrganSelect
            // 
            OrganSelect.CheckedState.ImageSize = new Size(64, 64);
            OrganSelect.HoverState.ImageSize = new Size(137, 137);
            OrganSelect.Image = Properties.Resources.Organ_choice;
            OrganSelect.ImageOffset = new Point(0, 0);
            OrganSelect.ImageRotate = 0F;
            OrganSelect.ImageSize = new Size(137, 137);
            OrganSelect.Location = new Point(529, 163);
            OrganSelect.Name = "OrganSelect";
            OrganSelect.PressedState.ImageSize = new Size(64, 64);
            OrganSelect.ShadowDecoration.CustomizableEdges = customizableEdges1;
            OrganSelect.Size = new Size(137, 128);
            OrganSelect.TabIndex = 20;
            OrganSelect.Click += guna2ImageButton2_Click;
            // 
            // BloodSelect
            // 
            BloodSelect.CheckedState.ImageSize = new Size(64, 64);
            BloodSelect.HoverState.ImageSize = new Size(137, 137);
            BloodSelect.Image = Properties.Resources.Blood_choice;
            BloodSelect.ImageOffset = new Point(0, 0);
            BloodSelect.ImageRotate = 0F;
            BloodSelect.ImageSize = new Size(137, 137);
            BloodSelect.Location = new Point(134, 163);
            BloodSelect.Name = "BloodSelect";
            BloodSelect.PressedState.ImageSize = new Size(64, 64);
            BloodSelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BloodSelect.Size = new Size(137, 137);
            BloodSelect.TabIndex = 21;
            BloodSelect.Click += BloodSelect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(553, 294);
            label3.Name = "label3";
            label3.Size = new Size(88, 34);
            label3.TabIndex = 19;
            label3.Text = "Organ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(345, 74);
            label2.Name = "label2";
            label2.Size = new Size(111, 34);
            label2.TabIndex = 18;
            label2.Text = "Manage:";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(12, 396);
            button4.Name = "button4";
            button4.Size = new Size(115, 42);
            button4.TabIndex = 17;
            button4.Text = "Go Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 303);
            label1.Name = "label1";
            label1.Size = new Size(85, 34);
            label1.TabIndex = 16;
            label1.Text = "Blood";
            // 
            // SelectionEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(OrganSelect);
            Controls.Add(BloodSelect);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectionEmp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectionEmp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton OrganSelect;
        private Guna.UI2.WinForms.Guna2ImageButton BloodSelect;
        private Label label3;
        private Label label2;
        private Button button4;
        private Label label1;
    }
}