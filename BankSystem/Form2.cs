using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BankSystem
{
    public partial class Form2 : Form
    {
        private string image = "No Image";
        private void AddUser(User user)
        {
            string connectionString = "Server=localhost; Database=BankSystem; Integrated Security=True;";
            string commandText;
            if (image.Equals("No Image"))
                commandText = "EXEC AddUser @FirstName, @LastName, @Password,@accountType";
            else
                commandText = "EXEC AddUser @FirstName, @LastName, @Password,@accountType,@userphoto";



            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@FirstName", user.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", user.LastName);
                    sqlCommand.Parameters.AddWithValue("@Password", user.Password);
                    if (user.accountType == AccountType.Saving)
                        sqlCommand.Parameters.AddWithValue("@accountType", "saving");
                    else
                        sqlCommand.Parameters.AddWithValue("@accountType", "current");
                    if (!image.Equals("No Image"))
                        sqlCommand.Parameters.AddWithValue("@userphoto", image);

                    try
                    {
                        sqlConnection.Open();

                        object Affection = sqlCommand.ExecuteScalar();

                        int AccountID = Convert.ToInt32(Affection);

                        MessageBox.Show($"Your Account ID is : {AccountID}");

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
            this.Text = "Create Account";
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            btnConfirmCreation.Click += btnConfirmCreation_Click;
        }



        private void btnBackFrom2_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();

        }

        private void btnConfirmCreation_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string pattern = "^[A-Za-z]+$";
            if (!Regex.IsMatch(FirstName, pattern))
            {
                MessageBox.Show("Enter Valid Name");
                return;
            }

            string LastName = txtLastName.Text;

            if (!Regex.IsMatch(LastName, pattern))
            {
                MessageBox.Show("Enter Valid Name");
                return;
            }

            AccountType accountType;

            if (rbCurrent.Checked)
                accountType = AccountType.current;
            else if (rbSaving.Checked)
                accountType = AccountType.Saving;
            else
            {
                MessageBox.Show("Select Account Type");
                return;
            }

            string Password = txtPassword.Text;
            if (Password.Length < 8)
            {
                MessageBox.Show("Enter a strong password");
                return;
            }
            string ConfirmPassword = txtConfirmPassword.Text;
            if (!ConfirmPassword.Equals(Password))
            {
                MessageBox.Show("The password is inconsistent");
                return;
            }

            User user = new User.Builder()
                                .setFirstName(FirstName)
                                .setLastName(LastName)
                                .setPassword(Password)
                                .setAccountType(accountType)
                                .setImage(image)
                                .Build();
            AddUser(user);
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select An Image";
            openFileDialog1.InitialDirectory = "C:\\Users\\Ahmed Salah\\Pictures";
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    image = openFileDialog1.FileName;
            }
        }

       
    }
}
