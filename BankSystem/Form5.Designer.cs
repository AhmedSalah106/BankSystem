namespace BankSystem
{
    partial class Form5
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
            btnDeposit = new Button();
            btnWithdrow = new Button();
            btnBackForm5 = new Button();
            SuspendLayout();
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(131, 138);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(175, 77);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdrow
            // 
            btnWithdrow.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdrow.Location = new Point(474, 138);
            btnWithdrow.Name = "btnWithdrow";
            btnWithdrow.Size = new Size(175, 77);
            btnWithdrow.TabIndex = 1;
            btnWithdrow.Text = "Withdrow";
            btnWithdrow.UseVisualStyleBackColor = true;
            btnWithdrow.Click += btnWithdrow_Click;
            // 
            // btnBackForm5
            // 
            btnBackForm5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackForm5.Location = new Point(326, 293);
            btnBackForm5.Name = "btnBackForm5";
            btnBackForm5.Size = new Size(152, 73);
            btnBackForm5.TabIndex = 2;
            btnBackForm5.Text = "Back";
            btnBackForm5.UseVisualStyleBackColor = true;
            btnBackForm5.Click += btnBackForm5_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackForm5);
            Controls.Add(btnWithdrow);
            Controls.Add(btnDeposit);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeposit;
        private Button btnWithdrow;
        private Button btnBackForm5;
    }
}