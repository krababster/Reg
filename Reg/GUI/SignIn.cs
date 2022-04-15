using System;
using Reg.Controller;
using System.Windows.Forms;

namespace Reg.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RegController newUser = new RegController();
            foreach (var emails in newUser.VerifyEmail())
            {
                if (textBox1.Text == emails.user_email)
                {
                    MessageBox.Show("Вход выполнен успешно!");
                    return;
                }
            }
                    MessageBox.Show("email введен неверно");
                return;

           
        }
    }
}
