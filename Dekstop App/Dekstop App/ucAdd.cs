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
    public partial class ucAdd : UserControl
    {
        private static ucAdd ok;
        public static ucAdd Ok
        {
            get
            {
                if (ok == null)
                {
                    ok = new ucAdd();
                }
                return ok;
            }
        }
        private ucAdd()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                int price, quantity;
                name = txtName.Text;
                price = int.Parse(txtPass.Text);
                quantity = int.Parse(txtQuantity.Text);
                item u = new item(name, price, quantity);
                itemDL.addItemIntoCustomerList(u);
                itemDL.savedata(ucDeserts.Instance.items_path);
                ucDeserts.Instance.dataBind();
                MessageBox.Show("Item Added", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Clear();
                txtPass.Clear();
                txtQuantity.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}