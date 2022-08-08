using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_App
{
    public partial class Admin_Menu_Form : Form
    {
        public Admin_Menu_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Menu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(ucDeserts.Instance))
            {
                ucDeserts.Instance.BringToFront();
            }
            else
            {
                pnlContainer.Controls.Add(ucDeserts.Instance);
                ucDeserts.Instance.Dock = DockStyle.Fill;
                ucDeserts.Instance.BringToFront();
            }
        }
    }
}
