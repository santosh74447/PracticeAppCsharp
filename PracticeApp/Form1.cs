using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text.Trim();
            string pwd = txtPassword.Text.Trim();
            if (user.Length <= 0)
            {
                MessageBox.Show( "Username cannot be empty!!", "Error", MessageBoxButtons.OK);
                txtUserName.Focus();
                return;
            }
            if (pwd.Length <= 0)
            {
                MessageBox.Show("Password cannot be empty!!", "Error", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }

            if(user=="san" && pwd == "san")
            {
                MessageBox.Show("Welcome to code practice center", "Success", MessageBoxButtons.OK);

                this.Hide();
                MainForm mform = new MainForm();
                mform.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!!", "Error", MessageBoxButtons.OK);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
                return;
            }



        }
    }
}
