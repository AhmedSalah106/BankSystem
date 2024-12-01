namespace BankSystem
{
    partial class Form6
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
            lblAmountDeposit = new Label();
            txtAmountDeposit = new TextBox();
            btnConfirmDeposit = new Button();
            btnBackFromDeposit = new Button();
            lblProcessCompleted = new Label();
            SuspendLayout();
            // 
            // lblAmountDeposit
            // 
            lblAmountDeposit.AutoSize = true;
            lblAmountDeposit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountDeposit.Location = new Point(25, 151);
            lblAmountDeposit.Name = "lblAmountDeposit";
            lblAmountDeposit.Size = new Size(433, 31);
            lblAmountDeposit.TabIndex = 0;
            lblAmountDeposit.Text = "Enter the amount you want to deposit :";
            // 
            // txtAmountDeposit
            // 
            txtAmountDeposit.Location = new Point(515, 157);
            txtAmountDeposit.Name = "txtAmountDeposit";
            txtAmountDeposit.Size = new Size(175, 27);
            txtAmountDeposit.TabIndex = 1;
            // 
            // btnConfirmDeposit
            // 
            btnConfirmDeposit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfirmDeposit.Location = new Point(486, 277);
            btnConfirmDeposit.Name = "btnConfirmDeposit";
            btnConfirmDeposit.Size = new Size(144, 62);
            btnConfirmDeposit.TabIndex = 2;
            btnConfirmDeposit.Text = "Confirm";
            btnConfirmDeposit.UseVisualStyleBackColor = true;
            btnConfirmDeposit.Click += btnConfirmDeposit_Click;
            // 
            // btnBackFromDeposit
            // 
            btnBackFromDeposit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackFromDeposit.Location = new Point(207, 277);
            btnBackFromDeposit.Name = "btnBackFromDeposit";
            btnBackFromDeposit.Size = new Size(144, 62);
            btnBackFromDeposit.TabIndex = 3;
            btnBackFromDeposit.Text = "Back";
            btnBackFromDeposit.UseVisualStyleBackColor = true;
            btnBackFromDeposit.Click += btnBackFromDeposit_Click;
            // 
            // lblProcessCompleted
            // 
            lblProcessCompleted.AutoSize = true;
            lblProcessCompleted.Enabled = false;
            lblProcessCompleted.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProcessCompleted.ForeColor = SystemColors.HotTrack;
            lblProcessCompleted.Location = new Point(258, 217);
            lblProcessCompleted.Name = "lblProcessCompleted";
            lblProcessCompleted.Size = new Size(282, 31);
            lblProcessCompleted.TabIndex = 4;
            lblProcessCompleted.Text = "The process is completed";
            lblProcessCompleted.Visible = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProcessCompleted);
            Controls.Add(btnBackFromDeposit);
            Controls.Add(btnConfirmDeposit);
            Controls.Add(txtAmountDeposit);
            Controls.Add(lblAmountDeposit);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmountDeposit;
        private TextBox txtAmountDeposit;
        private Button btnConfirmDeposit;
        private Button btnBackFromDeposit;
        private Label lblProcessCompleted;
    }
}