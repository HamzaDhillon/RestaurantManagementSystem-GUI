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
using Dekstop_App.BL;

namespace Dekstop_App
{
    public partial class ucDeserts : UserControl
    {
        public string items_path = "items.txt";
        private static ucDeserts _instance;

        public static ucDeserts Instance{
            get
            {
                if (_instance == null)
                {
                    _instance = new ucDeserts();
                }
                return _instance;
            }
        }
        public ucDeserts()
        {
            InitializeComponent();
            gvitems.DataSource = itemDL.ItemsData;
        }
        public void dataBind()
        {
            gvitems.DataSource = null;
            gvitems.DataSource = itemDL.ItemsData;
            gvitems.Refresh();

        }

        private void gvitems_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            item u = (item)gvitems.CurrentRow.DataBoundItem;
            if (gvitems.Columns["Delete"].Index == e.ColumnIndex)
            {
                itemDL.removeitem(u);
                itemDL.savedata(items_path);
                dataBind();
            }
            if (gvitems.Columns["Edit"].Index == e.ColumnIndex)
            {
                if (panel3.Controls.Contains(ucEdit.Instance))
                {
                    ucEdit.Instance.setEditFeilds(u);
                    ucEdit.Instance.BringToFront();
                }
                else
                {
                    panel3.Controls.Add(ucEdit.Instance);
                    ucEdit.Instance.Dock = DockStyle.Fill;
                    ucEdit.Instance.setEditFeilds(u);
                    ucEdit.Instance.BringToFront();

                }
            }
        }
    }
}
