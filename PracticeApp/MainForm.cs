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
    public partial class MainForm : Form
    {
        public MainForm(bool islogin)
        {
            InitializeComponent();

            if (islogin == true)
            {
                menuIsLogin.Text = "Logout";
            }
            else
            {
                Form1 loginFrm = new Form1();
                loginFrm.ShowDialog();
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUser rUser = new RegisterUser();
            rUser.ShowDialog();
        }
    }
}
