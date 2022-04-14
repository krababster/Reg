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

        private void regBtn_Click(object sender, EventArgs e)

        {
            RegController newUser = new RegController();

            foreach (var emails in newUser.Validate())
            {
                if (emailTextBox.Text == emails.user_email)
                {
                    MessageBox.Show("Такой пользователь уже существует.");
                    this.emailTextBox.Text = "";
                    return;
                }
            }
            newUser.Registration(emailTextBox.Text, passTextBox.Text);
            if (passTextBox.TextLength <= 5)
                MessageBox.Show("Слишком короткий пароль!");

            //newUser.Registration(emailTextBox.Text, passTextBox.Text);

        }


        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (passTextBox.Text == "")
            //    regBtn.Enabled = false;
            //else
            //    regBtn.Enabled = true;
        }
    }
}
