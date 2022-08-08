using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekstop_App.BL
{
    class users
    {

        public users()
        {

        }
        public users(string name, string pass)
        {
            this.Name = name;
            this.Pass = pass;
        }
        private string name;
        private string pass;
        private string role;

        public string Name { get => name; set => name = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Role { get => role; set => role = value; }
    }
}
