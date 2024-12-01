namespace BankSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CreateAccount = new Button();
            SignIn = new Button();
            pictureForm1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureForm1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(254, 67);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Our Bank";
            // 
            // CreateAccount
            // 
            CreateAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateAccount.ForeColor = SystemColors.HotTrack;
            CreateAccount.Location = new Point(83, 267);
            CreateAccount.Name = "CreateAccount";
            CreateAccount.Size = new Size(198, 59);
            CreateAccount.TabIndex = 1;
            CreateAccount.Text = "Create Account";
            CreateAccount.UseVisualStyleBackColor = true;
            CreateAccount.Click += CreateAccount_Click;
            // 
            // SignIn
            // 
            SignIn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SignIn.ForeColor = SystemColors.HotTrack;
            SignIn.Location = new Point(508, 267);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(198, 59);
            SignIn.TabIndex = 2;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // pictureForm1
            // 
            pictureForm1.Location = new Point(33, 67);
            pictureForm1.Name = "pictureForm1";
            pictureForm1.Size = new Size(155, 113);
            pictureForm1.TabIndex = 3;
            pictureForm1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureForm1);
            Controls.Add(SignIn);
            Controls.Add(CreateAccount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "d";
            ((System.ComponentModel.ISupportInitialize)pictureForm1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreateAccount;
        private Button SignIn;
        private PictureBox pictureForm1;
    }
}
