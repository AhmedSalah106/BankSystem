using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public bool WithdrawById(int Amount)
        {
            int AccountID = Form8.GetAccount().ID;

            string connection = "Server=localhost; Database=BankSystem; Integrated Security=True;";

            string command = $"exec withdrawById {7} , {Amount}";

            SqlConnection sqlConnection = new SqlConnection(connection);
            
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlConnection.Open();

                int RowAffected = sqlCommand.ExecuteNonQuery();

                if (RowAffected == -1)
                {
                 
                    MessageBox.Show("Your current balance is not enough");

                    return false;
                }
                else
                {
                    MessageBox.Show("Process Completed" );

                    return false;
                }

            }
            catch(SqlException ex)
            {
                MessageBox.Show("SQL ERROR : " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " +  ex.Message);
            }
            return false;
        }
        private void ConfrimWithdraw_Click(object sender, EventArgs e)
        {
            int AmountFromWithdraw;

            if (int.TryParse(txtWithdraw.Text, out AmountFromWithdraw))
            {
                if(WithdrawById(AmountFromWithdraw))
                     lblProcessCompleted.Visible = true;
                else
                    lblProcessCompleted.Visible = false;

            }
            else
            {
                lblProcessCompleted.Visible = false;


                MessageBox.Show("Enter Valid Number");
            }
        }

        private void btnBackFromForm7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
