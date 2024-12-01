namespace BankSystem
{
    partial class Form2
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnConfirmCreation = new Button();
            lblAccountType = new Label();
            rbSaving = new RadioButton();
            rbCurrent = new RadioButton();
            btnBackFrom2 = new Button();
            lblCreationCompleted = new Label();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(115, 9);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(176, 38);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(312, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(237, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(120, 62);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(171, 38);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(312, 73);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(237, 27);
            txtLastName.TabIndex = 3;
            // 
            // btnConfirmCreation
            // 
            btnConfirmCreation.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfirmCreation.Location = new Point(459, 374);
            btnConfirmCreation.Name = "btnConfirmCreation";
            btnConfirmCreation.Size = new Size(164, 50);
            btnConfirmCreation.TabIndex = 4;
            btnConfirmCreation.Text = "Confirm";
            btnConfirmCreation.UseVisualStyleBackColor = true;
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountType.Location = new Point(80, 111);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(211, 38);
            lblAccountType.TabIndex = 5;
            lblAccountType.Text = "Account Type :";
            // 
            // rbSaving
            // 
            rbSaving.AutoSize = true;
            rbSaving.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSaving.Location = new Point(312, 116);
            rbSaving.Name = "rbSaving";
            rbSaving.Size = new Size(96, 32);
            rbSaving.TabIndex = 6;
            rbSaving.TabStop = true;
            rbSaving.Text = "Saving";
            rbSaving.UseVisualStyleBackColor = true;
            // 
            // rbCurrent
            // 
            rbCurrent.AutoSize = true;
            rbCurrent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbCurrent.Location = new Point(445, 117);
            rbCurrent.Name = "rbCurrent";
            rbCurrent.Size = new Size(104, 32);
            rbCurrent.TabIndex = 7;
            rbCurrent.TabStop = true;
            rbCurrent.Text = "Current";
            rbCurrent.UseVisualStyleBackColor = true;
            // 
            // btnBackFrom2
            // 
            btnBackFrom2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackFrom2.Location = new Point(173, 374);
            btnBackFrom2.Name = "btnBackFrom2";
            btnBackFrom2.Size = new Size(164, 50);
            btnBackFrom2.TabIndex = 8;
            btnBackFrom2.Text = "Back";
            btnBackFrom2.UseVisualStyleBackColor = true;
            btnBackFrom2.Click += btnBackFrom2_Click;
            // 
            // lblCreationCompleted
            // 
            lblCreationCompleted.AutoSize = true;
            lblCreationCompleted.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreationCompleted.ForeColor = SystemColors.HotTrack;
            lblCreationCompleted.Location = new Point(161, 315);
            lblCreationCompleted.Name = "lblCreationCompleted";
            lblCreationCompleted.Size = new Size(462, 31);
            lblCreationCompleted.TabIndex = 9;
            lblCreationCompleted.Text = "The account has been created successfully";
            lblCreationCompleted.Visible = false;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(12, 221);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(279, 38);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Comfirm Password :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(136, 162);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(155, 38);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(312, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(237, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(312, 232);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(237, 27);
            txtConfirmPassword.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialogForm2";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(312, 276);
            button1.Name = "button1";
            button1.Size = new Size(237, 36);
            button1.TabIndex = 14;
            button1.Text = "AddPhoto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblCreationCompleted);
            Controls.Add(btnBackFrom2);
            Controls.Add(rbCurrent);
            Controls.Add(rbSaving);
            Controls.Add(lblAccountType);
            Controls.Add(btnConfirmCreation);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnConfirmCreation;
        private Label lblAccountType;
        private CheckBox cbSaving;
        private CheckBox cbCurrent;
        private RadioButton rbSaving;
        private RadioButton rbCurrent;
        private Button btnBackFrom2;
        private Label lblCreationCompleted;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private OpenFileDialog openFileDialog1;
        private Button button1;
    }
}