using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {
            rbPrintReceipt form4 = new rbPrintReceipt();

            form4.Show();

            this.Hide();

        }

        private void btnBankingTransaction_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();

            this.Hide();

        }

        private void btnBackForm3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  

            form1.Show(); 

            this.Hide();
        }
    }
}
