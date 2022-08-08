using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dekstop_App;
using Dekstop_App.DL;


namespace Dekstop_App
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            string users_path = "users.txt";
            if (usersDL.readlogindata(users_path) == true)
            {
                MessageBox.Show("Users Data Loaded succesfully !");
            }
            else
            {
                MessageBox.Show("Users Data not Loaded succesfully !");
            }

        }
      
        private void Sign_In_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Hello There");
            Sign_In form = new Sign_In();
            this.Hide();
            form.Show();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void Sign_up_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
