namespace BankSystem
{
    partial class rbPrintReceipt
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
            label1 = new Label();
            txtTotalAmount = new TextBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            rbNoPrintReceipt = new RadioButton();
            btnBackFromForm4 = new Button();
            pictureBoxBalance = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBalance).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 106);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(352, 38);
            label1.TabIndex = 0;
            label1.Text = "Your Account Balance Is :";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(394, 98);
            txtTotalAmount.Margin = new Padding(3, 4, 3, 4);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(233, 43);
            txtTotalAmount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 208);
            label2.Name = "label2";
            label2.Size = new Size(274, 38);
            label2.TabIndex = 2;
            label2.Text = "Print Your Receipt :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(394, 206);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 32);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yes";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbNoPrintReceipt
            // 
            rbNoPrintReceipt.AutoSize = true;
            rbNoPrintReceipt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbNoPrintReceipt.Location = new Point(558, 208);
            rbNoPrintReceipt.Margin = new Padding(3, 4, 3, 4);
            rbNoPrintReceipt.Name = "rbNoPrintReceipt";
            rbNoPrintReceipt.Size = new Size(61, 32);
            rbNoPrintReceipt.TabIndex = 4;
            rbNoPrintReceipt.TabStop = true;
            rbNoPrintReceipt.Text = "No";
            rbNoPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // btnBackFromForm4
            // 
            btnBackFromForm4.Location = new Point(385, 353);
            btnBackFromForm4.Margin = new Padding(3, 4, 3, 4);
            btnBackFromForm4.Name = "btnBackFromForm4";
            btnBackFromForm4.Size = new Size(134, 57);
            btnBackFromForm4.TabIndex = 5;
            btnBackFromForm4.Text = "Back";
            btnBackFromForm4.UseVisualStyleBackColor = true;
            btnBackFromForm4.Click += btnBackFromForm4_Click;
            // 
            // pictureBoxBalance
            // 
            pictureBoxBalance.Location = new Point(710, 98);
            pictureBoxBalance.Name = "pictureBoxBalance";
            pictureBoxBalance.Size = new Size(144, 122);
            pictureBoxBalance.TabIndex = 6;
            pictureBoxBalance.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rbPrintReceipt
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 537);
            Controls.Add(pictureBoxBalance);
            Controls.Add(btnBackFromForm4);
            Controls.Add(rbNoPrintReceipt);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(txtTotalAmount);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "rbPrintReceipt";
            Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBalance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTotalAmount;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton rbNoPrintReceipt;
        private Button btnBackFromForm4;
        private PictureBox pictureBoxBalance;
        private OpenFileDialog openFileDialog1;
    }
}