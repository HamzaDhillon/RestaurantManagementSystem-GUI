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
    public partial class ucThreshold : UserControl
    {
        private static ucThreshold _instance;

        public static ucThreshold Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucThreshold();
                }
                return _instance;
            }
        }
        public ucThreshold()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
