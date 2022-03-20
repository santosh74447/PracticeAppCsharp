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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.Focus();
                return;
            }
            if (!rdbMale.Checked&&!rdbFemale.Checked&&!rdbOther.Checked)
            {
                lblErrorMessage.Text = "Please Select Gender";
                lblErrorMessage.ForeColor = Color.Red;
                return;
            }
            if (cmbState.SelectedIndex==0)
            {
                lblErrorMessage.Text = "Please Select State";
                lblErrorMessage.ForeColor = Color.Red;
                return;
            }
            if (!chkBooks.Checked && !chkMovies.Checked && !chkGames.Checked && !chkDrawing.Checked)
            {
                lblErrorMessage.Text = "Please Select atleast one hobbies from the list";
                lblErrorMessage.ForeColor = Color.Red;
                return;
            }

            MessageBox.Show("Data Validated Successfully", "Success", MessageBoxButtons.OK);
        }
    }
}
