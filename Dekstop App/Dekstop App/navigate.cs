using Dekstop_App.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_App
{
    public class navigate
    {

        public static void ToDesserts()
        {

            if (Admin_Menu_Form.Instance.pnlContainer.Controls.Contains(ucDeserts.Instance))
            {

                MessageBox.Show("lo g");
                ucDeserts.Instance.BringToFront();
            }
            else
            {
                Admin_Menu_Form.Instance.pnlContainer.Controls.Add(ucDeserts.Instance);
                ucDeserts.Instance.Dock = DockStyle.Fill;
                ucDeserts.Instance.BringToFront();
                MessageBox.Show("hello");
            }
        }
        public static void toAdd()
        {
            if (Admin_Menu_Form.Instance.pnlContainer.Controls.Contains(ucAdd.Ok))
            {
                ucAdd.Ok.BringToFront();
            }
            else
            {
                Admin_Menu_Form.Instance.pnlContainer.Controls.Add(ucAdd.Ok);
                ucAdd.Ok.Dock = DockStyle.Fill;
                ucAdd.Ok.BringToFront();
            }

        }
        public static void toEdit(item u)
        {
            if (Admin_Menu_Form.Instance.pnlContainer.Controls.Contains(ucEdit.Instance))
            {
                ucEdit.Instance.setEditFeilds(u);
                ucEdit.Instance.BringToFront();
            }
            else
            {
                Admin_Menu_Form.Instance.pnlContainer.Controls.Add(ucEdit.Instance);
                ucEdit.Instance.Dock = DockStyle.Fill;
                ucEdit.Instance.setEditFeilds(u);
                ucEdit.Instance.BringToFront();
            }

        }
    }
}
    

