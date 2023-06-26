using System;
using System.Windows.Forms;

namespace SignUpForm
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void passwordTextBox_IconRightClick(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.PasswordChar = '●';
            }
        }
    }
}
