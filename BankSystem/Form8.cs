using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form8 : Form
    {
        private static Account account;
        public Form8()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public static Account GetAccount()
        {
            return account;
        }
        private bool CheckByIDAndPassword(string password, int id)
        {
            string connectionString = "Server=localhost; Database=BankSystem; Integrated Security=True;";
            string commandText = "Exec getUserByIdAndPassword @Id, @Password";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.AddWithValue("@Password", password);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (!sqlDataReader.HasRows)
                        return false;
                    while (sqlDataReader.Read())
                    {
                        account = new Account.Builder()
                                         .setID(sqlDataReader.GetInt32(0)) 
                                         .setTotalAmount(sqlDataReader.GetInt32(2)) 
                                         .Build();
                    }
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            return false;
        }

        private void btnBackFromFrom8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            int id;
            string password = txtPassword.Text;
            if (!int.TryParse(txtAccountID.Text, out id))
            {
                MessageBox.Show("Enter Valid ID");
                return;
            }

            if (password.Length<8)
            {
                MessageBox.Show("Password Must Be 8 chars or more");
                return;
            }
            bool check = CheckByIDAndPassword(password, id);
            if (check)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Create Account Before User Our Services");
            }
        }
    }
}
