namespace BankSystem
{
    partial class Form3
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
            btnBalanceInquiry = new Button();
            btnBankingTransaction = new Button();
            btnBackForm3 = new Button();
            SuspendLayout();
            // 
            // btnBalanceInquiry
            // 
            btnBalanceInquiry.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalanceInquiry.Location = new Point(142, 149);
            btnBalanceInquiry.Name = "btnBalanceInquiry";
            btnBalanceInquiry.Size = new Size(200, 103);
            btnBalanceInquiry.TabIndex = 0;
            btnBalanceInquiry.Text = "Balance inquiry";
            btnBalanceInquiry.UseVisualStyleBackColor = true;
            btnBalanceInquiry.Click += btnBalanceInquiry_Click;
            // 
            // btnBankingTransaction
            // 
            btnBankingTransaction.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBankingTransaction.Location = new Point(441, 149);
            btnBankingTransaction.Name = "btnBankingTransaction";
            btnBankingTransaction.Size = new Size(200, 103);
            btnBankingTransaction.TabIndex = 1;
            btnBankingTransaction.Text = "Banking Transaction";
            btnBankingTransaction.UseVisualStyleBackColor = true;
            btnBankingTransaction.Click += btnBankingTransaction_Click;
            // 
            // btnBackForm3
            // 
            btnBackForm3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackForm3.Location = new Point(335, 311);
            btnBackForm3.Name = "btnBackForm3";
            btnBackForm3.Size = new Size(126, 72);
            btnBackForm3.TabIndex = 2;
            btnBackForm3.Text = "Back";
            btnBackForm3.UseVisualStyleBackColor = true;
            btnBackForm3.Click += btnBackForm3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackForm3);
            Controls.Add(btnBankingTransaction);
            Controls.Add(btnBalanceInquiry);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBalanceInquiry;
        private Button btnBankingTransaction;
        private Button btnBackForm3;
    }
}