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
    public partial class ucEdit : UserControl
    {
        private static ucEdit _instance;

        private item previous;
        public static ucEdit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucEdit();
                }
                return _instance;
            }
        }
        private ucEdit()
        {
            InitializeComponent();
        }
        public ucEdit(item previous)
        {
            InitializeComponent();
            this.previous = previous;
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucEdit_Load(object sender, EventArgs e)
        {
            
        }

        public void setEditFeilds(item i)
        {
            previous = i;
            txtName.Text = previous.Name;
            txtPrice.Text = previous.Price.ToString();
            txtQuantity.Text = previous.Quantity.ToString();
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            item updated = new item(txtName.Text, int.Parse(txtPrice.Text), int.Parse(txtQuantity.Text));
            itemDL.update_item(previous, updated);
            navigate.ToDesserts();
        }
    }
}
