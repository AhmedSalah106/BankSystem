using System.Windows.Forms;

namespace BankSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Welcome";
            try
            {
                string imagePath = @"C:\Users\Ahmed Salah\Pictures\Screenshots\Screenshot (24).png";

                pictureForm1.Image = Image.FromFile(imagePath);
                pictureForm1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The image file was not found. Please check the path and file name.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }


        private void CreateAccount_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();

            form8.Show();

            this.Hide();
        }

    }
}
