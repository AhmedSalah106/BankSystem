namespace BankSystem
{
    partial class Form7
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
            btnBackFromForm7 = new Button();
            ConfrimWithdraw = new Button();
            lblWithdrow = new Label();
            txtWithdraw = new TextBox();
            lblProcessCompleted = new Label();
            SuspendLayout();
            // 
            // btnBackFromForm7
            // 
            btnBackFromForm7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackFromForm7.Location = new Point(178, 259);
            btnBackFromForm7.Name = "btnBackFromForm7";
            btnBackFromForm7.Size = new Size(184, 56);
            btnBackFromForm7.TabIndex = 0;
            btnBackFromForm7.Text = "Back";
            btnBackFromForm7.UseVisualStyleBackColor = true;
            btnBackFromForm7.Click += btnBackFromForm7_Click;
            // 
            // ConfrimWithdraw
            // 
            ConfrimWithdraw.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ConfrimWithdraw.Location = new Point(457, 259);
            ConfrimWithdraw.Name = "ConfrimWithdraw";
            ConfrimWithdraw.Size = new Size(184, 56);
            ConfrimWithdraw.TabIndex = 1;
            ConfrimWithdraw.Text = "Confirm";
            ConfrimWithdraw.UseVisualStyleBackColor = true;
            ConfrimWithdraw.Click += ConfrimWithdraw_Click;
            // 
            // lblWithdrow
            // 
            lblWithdrow.AutoSize = true;
            lblWithdrow.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWithdrow.Location = new Point(42, 140);
            lblWithdrow.Name = "lblWithdrow";
            lblWithdrow.Size = new Size(454, 31);
            lblWithdrow.TabIndex = 2;
            lblWithdrow.Text = "Enter the amount you want to withdraw :";
            // 
            // txtWithdraw
            // 
            txtWithdraw.Location = new Point(535, 146);
            txtWithdraw.Name = "txtWithdraw";
            txtWithdraw.Size = new Size(149, 27);
            txtWithdraw.TabIndex = 3;
            // 
            // lblProcessCompleted
            // 
            lblProcessCompleted.AutoSize = true;
            lblProcessCompleted.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProcessCompleted.ForeColor = SystemColors.HotTrack;
            lblProcessCompleted.Location = new Point(276, 200);
            lblProcessCompleted.Name = "lblProcessCompleted";
            lblProcessCompleted.Size = new Size(282, 31);
            lblProcessCompleted.TabIndex = 4;
            lblProcessCompleted.Text = "The process is completed";
            lblProcessCompleted.Visible = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProcessCompleted);
            Controls.Add(txtWithdraw);
            Controls.Add(lblWithdrow);
            Controls.Add(ConfrimWithdraw);
            Controls.Add(btnBackFromForm7);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackFromForm7;
        private Button ConfrimWithdraw;
        private Label lblWithdrow;
        private TextBox txtWithdraw;
        private Label lblProcessCompleted;
    }
}