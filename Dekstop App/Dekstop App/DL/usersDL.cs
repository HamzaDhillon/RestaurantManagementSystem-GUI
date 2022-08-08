using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dekstop_App.BL;
using System.IO;
using System.Windows;

namespace Dekstop_App.DL
{
    class usersDL
    {

		private static List<users> usersData = new List<users>();
		internal static List<users> UsersData { get => usersData; set => usersData = value; }

        public static void addUsersIntoList(users u)
		{
			usersData.Add(u);
		}
		public static string sign_in(users u)
		{
			foreach (users i in UsersData)
			{
				if (u.Name == i.Name && u.Pass == i.Pass)
				{
					return i.Role;
				}
			}
			return null;
		}

		public static users sign_in_index(users u)
		{
			foreach (users i in UsersData)
			{
				if (u.Name == i.Name && u.Pass == i.Pass)
				{
					return i;
				}
			}
			return null;
		}

		public static bool validate(users u)
		{
			// For Same Passwords

			foreach (users i in UsersData)
			{
				if (u.Pass == i.Pass)
				{
					return false;
				}
			}
			return true;
		}

		public static void sign_up(users u)
		{
			int count = 0;
			while (u.Pass[count] != '\0')
			{
				count++;
			}
			while (count != 8)
			{
				count = 0;
				Console.WriteLine("Enter your password (Only 8 Characters): ");
				u.Pass = Console.ReadLine();

				while (u.Pass[count] != '\0')
				{
					count++;
				}
			}
			count = 0;

			// validation in case of two same passwords
			while (validate(u) == false)
			{
				Console.Write("Please select another password ! It's already taken");
				Console.Write("\n");
				Console.Write("Enter your password : ");
				Console.Write("\n");
				u.Pass = Console.ReadLine();
				while (u.Pass[count] != '\0')
				{
					count++;
				}
				while (count != 8)
				{
					count = 0;
					Console.Write("Enter your password (Only 8 Characters): ");
					Console.Write("\n");
					u.Pass = Console.ReadLine();

					while (u.Pass[count] != '\0')
					{
						count++;
					}
				}
			}
			u.Role = "CUSTOMER";
		}
		public static void adminsign_up(users u)
		{
			int count = 0;
			while (u.Pass[count] != '\0')
			{
				count++;
			}
			while (count != 8)
			{
				count = 0;
				Console.WriteLine("Enter your password (Only 8 Characters): ");
				u.Pass = Console.ReadLine();

				while (u.Pass[count] != '\0')
				{
					count++;
				}
			}
			count = 0;

			// validation in case of two same passwords
			while (validate(u) == false)
			{
				Console.Write("Please select another password ! It's already taken");
				Console.Write("\n");
				Console.Write("Enter your password : ");
				Console.Write("\n");
				u.Pass = Console.ReadLine();
				while (u.Pass[count] != '\0')
				{
					count++;
				}
				while (count != 8)
				{
					count = 0;
					Console.Write("Enter your password (Only 8 Characters): ");
					Console.Write("\n");
					u.Pass = Console.ReadLine();

					while (u.Pass[count] != '\0')
					{
						count++;
					}
				}
			}
			int option;
			Console.WriteLine("Select the role of user");
			Console.WriteLine();
			Console.WriteLine("1.Admin            (Press 1)     ");
			Console.WriteLine("2.Delievery boy    (Press 2)     ");
			option = int.Parse(Console.ReadLine());

			if (option == 1)
			{
				u.Role = "ADMIN";
			}
			else
			{
				u.Role = "delboy";
			}
		}
		public static void logindata(string path)
		{
			StreamWriter file = new StreamWriter(path);
			foreach (users i in usersData)
			{
				file.WriteLine(i.Name + "," + i.Pass + "," + i.Role);
			}
			file.Flush();
			file.Close();
		}
		public static bool readlogindata(string path)
		{
			string record;
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((record = file.ReadLine()) != null)
				{
					users s = new users();
					s.Name = parsedata(record, 1);
					s.Pass = parsedata(record, 2);
					s.Role = parsedata(record, 3);
					addUsersIntoList(s);
				}
				file.Close();
				return true;
			}
            else
            {
				return false;
            }
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
	}
}
