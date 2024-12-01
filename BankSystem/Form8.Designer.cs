namespace BankSystem
{
    partial class Form8
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
            lblAccountID = new Label();
            lblPassword = new Label();
            txtAccountID = new TextBox();
            txtPassword = new TextBox();
            btnBackFromFrom8 = new Button();
            btnConfrim = new Button();
            SuspendLayout();
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountID.Location = new Point(116, 100);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(163, 38);
            lblAccountID.TabIndex = 0;
            lblAccountID.Text = "Account ID";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(116, 186);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(139, 38);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(334, 111);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(213, 27);
            txtAccountID.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(334, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnBackFromFrom8
            // 
            btnBackFromFrom8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackFromFrom8.Location = new Point(197, 296);
            btnBackFromFrom8.Name = "btnBackFromFrom8";
            btnBackFromFrom8.Size = new Size(143, 61);
            btnBackFromFrom8.TabIndex = 4;
            btnBackFromFrom8.Text = "Back";
            btnBackFromFrom8.UseVisualStyleBackColor = true;
            btnBackFromFrom8.Click += btnBackFromFrom8_Click;
            // 
            // btnConfrim
            // 
            btnConfrim.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfrim.Location = new Point(447, 296);
            btnConfrim.Name = "btnConfrim";
            btnConfrim.Size = new Size(143, 61);
            btnConfrim.TabIndex = 5;
            btnConfrim.Text = "Confirm";
            btnConfrim.UseVisualStyleBackColor = true;
            btnConfrim.Click += btnConfrim_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfrim);
            Controls.Add(btnBackFromFrom8);
            Controls.Add(txtPassword);
            Controls.Add(txtAccountID);
            Controls.Add(lblPassword);
            Controls.Add(lblAccountID);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountID;
        private Label lblPassword;
        private TextBox txtAccountID;
        private TextBox txtPassword;
        private Button btnBackFromFrom8;
        private Button btnConfrim;
    }
}