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
        private static Form2 _instance;
        public static Form2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form2();
                }
                return _instance;
            }
        }

        private Form2()
        {
            InitializeComponent();
            string users_path = "users.txt";
            if (usersDL.readlogindata(users_path) == true)
            {
                //MessageBox.Show("Users Data Loaded succesfully !");
            }
            else
            {
                MessageBox.Show("Users Data not Loaded succesfully !");
            }
            string items_path = "items.txt";
            if (itemDL.datareader(items_path) == true)
            {
                //MessageBox.Show("iTEMs Data Loaded succesfully !");
            }
            else
            {
                MessageBox.Show("ITEMS Data not Loaded succesfully !");
            }
        }
      
        private void Sign_In_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_In.Instance.Show();
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
