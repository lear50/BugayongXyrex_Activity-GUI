using System;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class Form1 : Form
    {
        private int failedAttempts = 0; 
        private const int MaxFailedAttempts = 5; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userName = "xyrex";
            string passWord = "bugayong";

            if (UsernameTxtbox.Text == userName && PasswordTxtBox.Text == passWord)
            {
                failedAttempts = 0;
                Form form2 = new Form2();
                form2.Show();
            }
            else
            {
                failedAttempts++;

                if (failedAttempts >= MaxFailedAttempts)
                {
                    MessageBox.Show("Too many failed login attempts. \nReset password? https://resetpassword.com ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    failedAttempts = 0;
                    return;
                }

                if (string.IsNullOrEmpty(UsernameTxtbox.Text))
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Username is required!");
                    UsernameTxtbox.Focus();
                }
                else if (string.IsNullOrEmpty(PasswordTxtBox.Text))
                {
                    ErrorProvider1.SetError(PasswordTxtBox, "Password is required");
                    PasswordTxtBox.Focus();
                }
                else if (UsernameTxtbox.Text != userName && PasswordTxtBox.Text != passWord)
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Please input the correct username");
                    UsernameTxtbox.Focus();
                    ErrorProvider1.SetError(PasswordTxtBox, "Please use the correct password");
                    PasswordTxtBox.Focus();
                }
                else if (UsernameTxtbox.Text != userName)
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Please input the correct username");
                    UsernameTxtbox.Focus();
                }
                else if (PasswordTxtBox.Text != passWord)
                {
                    ErrorProvider1.SetError(PasswordTxtBox, "Please use the correct password");
                    PasswordTxtBox.Focus();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}