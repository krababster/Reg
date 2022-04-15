using System;
using System.Windows.Forms;
using Reg.Controller;

namespace Reg
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

            if (emailTextBox.TextLength == 0)
                regBtn.Enabled = false;
            else
                regBtn.Enabled = true;

        }
        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passTextBox.TextLength >= 5)
                regBtn.Enabled = true;
            else
                regBtn.Enabled = false;
        }
        private void regBtn_Click(object sender, EventArgs e)

        {
            RegController newUser = new RegController();

            string c = "@", d = ".";

            if (emailTextBox.Text.Contains(c) == false || emailTextBox.Text.Contains(d) == false)
            {
                MessageBox.Show("Неверный формат. E-mail должен содержать символы @ и .");
                return;
            }



            foreach (var emails in newUser.VerifyEmail())
            {
                if (emailTextBox.Text == emails.user_email)
                {
                    MessageBox.Show("Такой пользователь уже существует.");
                    this.emailTextBox.Text = "";
                    return;
                }
            }

            if (passTextBox.TextLength > 5)
            {
                newUser.Registration(emailTextBox.Text, passTextBox.Text);
                MessageBox.Show("Регистрация прошла успешно.");

            }
            else
                MessageBox.Show("Слишком короткий пароль!");


        }
    }
}

