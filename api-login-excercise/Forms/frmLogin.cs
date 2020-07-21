using api_login_excercise.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace api_login_excercise.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Service.LoginUser(txtUsername.Text, txtPassword.Text))
            {

                CallAPI api = new CallAPI();
                api.Show();

            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();

            }
        }
    }
}
