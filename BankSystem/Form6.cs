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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public bool DepositById(int Amount)
        {
            int UserID = Form8.GetAccount().ID;
           
            string connection = "Server=localhost; Database=BankSystem; Integrated Security=True;";

            string command = $"exec DepositById {UserID} , {Amount}";
            
            SqlConnection sqlConnection = new SqlConnection(connection);
            
            SqlCommand sqlCommand = new SqlCommand(command,sqlConnection);
            
            try
            {
                sqlConnection.Open();
              
                int RowAffected = sqlCommand.ExecuteNonQuery();

                if (RowAffected > 0)
                    MessageBox.Show("Process Completed");
                return true;
            }
            catch (SqlException ex)
            {
            
                MessageBox.Show("SQL ERROR : " + ex.Message); 
            }
            catch(Exception ex)
            {
           
                MessageBox.Show("ERROR : " + ex.Message);
            }
            return false;
        }

        private void btnBackFromDeposit_Click(object sender, EventArgs e)
        {
            Form5 from5 = new Form5();

            from5.Show();

            this.Hide();
        }

        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {
            int AmountFromDeposit;

            if (int.TryParse(txtAmountDeposit.Text, out AmountFromDeposit))
            {
                if(DepositById(AmountFromDeposit))
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
    }
}
