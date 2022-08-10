using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekstop_App.BL
{
    public class item
    {
		public item()
		{
		}
		public item(string name)
		{
			this.Name = name;
		}
		public item(string name, int quantity)
		{
			this.Name = name;
			this.Quantity = quantity;
		}
		public item(string name, int price, int quantity)
		{
			this.Name = name;
			this.Price = price;
			this.Quantity = quantity;
		}
        private string name;
        private int price;
        private int quantity;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
