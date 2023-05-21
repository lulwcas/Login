using System;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Policy;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Senha")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/home");
        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com");
        }
        private void pictureBoxGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}