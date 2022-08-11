using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dekstop_App.BL;
using System.IO;

namespace Dekstop_App.DL
{
    class itemDL
  {
        private static List<item> itemsData = new List<item>();
        private static List<item> customerProductData = new List<item>();

        internal static List<item> ItemsData { get => itemsData; set => itemsData = value; }
        internal static List<item> CustomerProductData { get => customerProductData; set => customerProductData = value; }

        public static void addItemIntoList(item u)
        {
            ItemsData.Add(u);
        }
        public static void addItemIntoCustomerList(item u)
        {
            CustomerProductData.Add(u);
        }
        public static void update_item(item previous,item updated)
        {
            foreach (item i in ItemsData)
            {
                if (i.Name == previous.Name)
                {
                    i.Name = updated.Name;
                    i.Price = updated.Price;
                    i.Quantity = updated.Quantity;
                }
            }
        }
        public static bool removeitem(item u)
        {
            foreach (item i in ItemsData)
            {
                if (u.Name == i.Name)
                {
                    ItemsData.Remove(i);
                    return true;
                }
            }
            return false;
        }
        public static float calculatebill(List<item> customerProductData)
        {
            float total = 0.0F;

            for (int i = 0; i < customerProductData.Count; i++)
            {
                total = total + customerProductData[i].Price;
            }
            return total;
        }
        //public static float discount(float bill)
        //{
        //	float discount;

        //	if (bill >= 1000 && bill < 2000)
        //	{
        //		discount = bill * 5 / 100.0F;
        //		return bill - discount;
        //	}
        //	else if (bill >= 2000 && bill < 3000)
        //	{
        //		discount = bill * 15 / 100.0F;
        //		return bill - discount;
        //	}
        //	else if (bill >= 3000)
        //	{
        //		discount = bill * 20 / 100.0F;
        //		return bill - discount;
        //	}
        //	return 0.0F;
        //}
        public static void savedata(string path)
        {
            StreamWriter file = new StreamWriter(path);

            foreach (item i in ItemsData)
            {
                file.WriteLine(i.Name + "," + i.Price + "," + i.Quantity);
            }
            file.Flush();
            file.Close();
        }
        public static bool datareader(string path)
        {
            string record;
            StreamReader file;
            // return if there is no file to load
            try
            {
                file = new StreamReader(path);
            }
            catch (Exception)
            {
                return false;
            }
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string name = parsedata(record, 1);
                    int price = int.Parse(parsedata(record, 2));
                    int quantity = int.Parse(parsedata(record, 3));
                    item u = new item(name, price, quantity);
                    addItemIntoList(u);
                }
                file.Close();
                return true;
            }
            return false;
          
        }
        private static string parsedata(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        
        
        //public static void order()
        //{
        //	CustomerProductData.Clear();
        //	//int customeritemcount = 0;
        //	string item;
        //	int n;
        //	Console.SetCursorPosition(0, 9);
        //	Console.WriteLine("Enter Date (DD/MM/YYYY): ");
        //	Console.SetCursorPosition(0, 10);
        //	Program.date = Console.ReadLine();
        //	Program.date = recordCRUD.datefunc(Program.date);
        //	Console.SetCursorPosition(35, 9);
        //	Console.WriteLine("No.of items to add : ");
        //	Console.SetCursorPosition(35, 10);
        //	n = int.Parse(Console.ReadLine());

        //	string name;
        //	int price, quantity;
        //	for (int i = 0; i < n; i++)
        //	{
        //		Console.WriteLine();
        //		Console.Write("Select food item (Enter \"0\" to end )  :  ");
        //		item = Console.ReadLine();
        //		Console.WriteLine();
        //		if (item == "0")
        //		{
        //			break;
        //		}
        //		bool flag = false;

        //		for (int z = 0; z < ItemsData.Count; z++)
        //		{
        //			if (item == ItemsData[z].Name)
        //			{
        //				// making a new array to calculate invoice
        //				name = item;
        //				Console.Write("Enter the quantity : ");
        //				quantity = int.Parse(Console.ReadLine());

        //				// if the item is in less quantity than that user want
        //				if (quantity > ItemsData[z].Quantity)
        //				{
        //					Console.WriteLine("Item not available in this quantity  ");
        //					Console.WriteLine();
        //					Console.Write("Available quantity  ");
        //					Console.WriteLine(ItemsData[z].Quantity);
        //					i--;
        //					flag = true;
        //					break;
        //				}
        //				// Minusing the quantity from manager item array which cusomer purchased
        //				ItemsData[z].Quantity = ItemsData[z].Quantity - quantity;
        //				price = quantity * ItemsData[z].Price;

        //				Console.Write("\t\t\t");
        //				Console.Write(name);
        //				Console.Write("\t");
        //				Console.Write(price);
        //				Console.Write("  rupees");
        //				Console.Write("\n");
        //				item u = new item(name, price, quantity);
        //				addItemIntoCustomerList(u);
        //				flag = true;
        //			}
        //		}
        //		if (flag == true)
        //		{
        //			flag = false;
        //		}
        //		else
        //		{
        //			Console.WriteLine(" Sorry! Item is not in our menu.");
        //			i--;
        //		}
        //	}
        //}
        //public static int availdeals(string op)
        //{
        //	customerProductData.Clear();
        //	int customeritemcount = 0;
        //	Console.WriteLine("Enter Date (DD/MM/YYYY): ");
        //	Program.date = Console.ReadLine();
        //	Program.date = recordCRUD.datefunc(Program.date);

        //	for (int z = 0; z < itemsData.Count; z++)
        //	{
        //		if (ItemsData[z].Name == "large pizza")
        //		{
        //			// making a new array to calculate invoice
        //			CustomerProductData[customeritemcount].Name = "large pizza";
        //			CustomerProductData[customeritemcount].Quantity = 2;

        //			// Minusing the quantity from manager item array which cusomer purchased
        //			ItemsData[z].Quantity = ItemsData[z].Quantity - CustomerProductData[customeritemcount].Quantity;

        //			CustomerProductData[customeritemcount].Price = CustomerProductData[customeritemcount].Quantity * itemsData[z].Price;
        //			customeritemcount++;
        //		}
        //		if (itemsData[z].Name == "medium pizza")
        //		{
        //			// making a new array to calculate invoice
        //			CustomerProductData[customeritemcount].Name = "medium pizza";
        //			CustomerProductData[customeritemcount].Quantity = 1;

        //			ItemsData[z].Quantity = ItemsData[z].Quantity - CustomerProductData[customeritemcount].Quantity;
        //			CustomerProductData[customeritemcount].Price = 0;
        //			customeritemcount++;
        //		}
        //	}
        //	return customeritemcount;
        //}
    }
}
