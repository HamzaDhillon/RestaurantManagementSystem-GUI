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
    public partial class ucDeserts : UserControl
    {
        private static ucDeserts _instance;

        public static ucDeserts Instance{
            get{
                if (_instance == null)
                {
                    _instance = new ucDeserts();
                }
                return _instance;
            }
        }
        private ucDeserts()
        {
            InitializeComponent();
        }
    }
}
