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
    public partial class rbPrintReceipt : Form
    {
        private void ChangePhototByID(string photo)
        {
            int AccountID = Form8.GetAccount().ID;

            string connectionString = "Server=localhost; Database=BankSystem; Integrated Security=True;";

            string command = $"exec updatePhotoByID 7 , '{photo}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlConnection.Open();

                int RowAffected = sqlCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL ERROR : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private Account getTotalAmount()
        {
            int AccountID = Form8.GetAccount().ID;

            string connectionString = "Server=localhost; Database=BankSystem; Integrated Security=True;";

            string command = $"exec GetAccountByID {AccountID}";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlConnection.Open();

                SqlDataReader adapter = sqlCommand.ExecuteReader();

                while (adapter.Read())
                {
                    return new Account.Builder()
                        .setID(AccountID)
                        .setPhoto(adapter.GetString(3))
                        .setTotalAmount(adapter.GetInt32(2))
                        .Build();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL ERROR : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            return new Account.Builder().Build();
        }
        public rbPrintReceipt()
        {
            InitializeComponent();   
            Account account = getTotalAmount();
            
            txtTotalAmount.Text = account.TotalAmount.ToString();

            FileStream file1 = new FileStream(account.photo, FileMode.Open, FileAccess.Read);

            pictureBoxBalance.Image = Image.FromStream(file1);

            pictureBoxBalance.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxBalance.Click += pictureBoxBalance_Click;
        }

        private void btnBackFromForm4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            
            form3.Show();
            
            this.Hide();
        }

        private void pictureBoxBalance_Click(object sender, EventArgs e)
        {

            try
            {
                openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Title = "Update You Photo";

                openFileDialog1.InitialDirectory = "C:\\Users\\Ahmed Salah\\Pictures";

                openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                    pictureBoxBalance.Image = Image.FromStream(file);

                    pictureBoxBalance.SizeMode = PictureBoxSizeMode.StretchImage;

                    ChangePhototByID(openFileDialog1.FileName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
