using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dekstop_App.DL;

namespace Dekstop_App
{
    public partial class Admin_Menu_Form : Form
    {
        private static Admin_Menu_Form _instance;
        public static Admin_Menu_Form Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Admin_Menu_Form();
                }
                return _instance;
            }
        }
        public Admin_Menu_Form()
        {
            InitializeComponent();
        }

        private void Admin_Menu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void iconButtondessert_Click_1(object sender, EventArgs e)
        {
            navigate.ToDesserts();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            navigate.toAdd();
        }

        private void iconbtnthreshold_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(ucThreshold.Instance))
            {
                ucThreshold.Instance.BringToFront();
            }
            else
            {
                pnlContainer.Controls.Add(ucThreshold.Instance);
                ucThreshold.Instance.Dock = DockStyle.Fill;
                ucThreshold.Instance.BringToFront();

            }
        }
    }
}
