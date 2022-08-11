using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dekstop_App.BL;
using Dekstop_App.DL;

namespace Dekstop_App
{
    public partial class Sign_In : Form
    {
        private static Sign_In _instance;
        public static Sign_In Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Sign_In();
                }
                return _instance;
            }
        }
        private Sign_In()
        {
            InitializeComponent();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }


        private void Sign_In_pass_Click(object sender, EventArgs e)
        {

        }
        private void enterbutton_Click(object sender, EventArgs e)
        {

        }

        private void cmdback_Click(object sender, EventArgs e)
        {

        }

        private void entercmd_Click(object sender, EventArgs e)
        {
            users u = new users(txtName.Text, txtpass.Text);
            if (usersDL.sign_in(u) != null)
            {
                this.Hide();
                Admin_Menu_Form.Instance.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Sign_In_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
