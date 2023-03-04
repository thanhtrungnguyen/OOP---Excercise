using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
	internal class Manager
	{
		private static Room roomA = new Room("A", 100);
		private static Room roomB = new Room("B", 200);
		private static Room roomC = new Room("C", 300);
		private static Hotel hotel = new Hotel();
		public static int Menu()
		{
			Console.WriteLine("-------------------------");
			Console.WriteLine("1: Show list");
			Console.WriteLine("2: Add person");
			Console.WriteLine("3: Rent amount ");
			Console.WriteLine("4: Remove");
			Console.WriteLine("5: Exit");
			Console.WriteLine("Your choice: ");
			int choice = Validation.CheckInputIntLimit(1, 5);
			return choice;
		}

		public static void ShowPeople()
		{
			hotel.People.ForEach(person => person.Show());

		}

		public static void AddPerson()
		{
			Console.WriteLine("Enter CitizenID:");
			string citizenId = Validation.CheckInputString();
			Console.WriteLine("Enter name:");
			string name = Validation.CheckInputString();
			Console.WriteLine("Enter age:");
			int age = Validation.CheckInputIntLimit(1, 1111);
			Console.WriteLine("Choose room: \n1. A\n2. B\n3. C");
			int option = Validation.CheckInputIntLimit(1, 3);
			Room roomOption = null;
			switch (option)
			{
				case 1:
					roomOption = roomA;
					break;
				case 2:
					roomOption = roomB;
					break;
				case 3:
					roomOption = roomC;
					break;
			}
			Console.WriteLine("Enter NumberOfDay:");
			int numberOfDay = Validation.CheckInputIntLimit(1, Int32.MaxValue);
			Person person = new Person(citizenId, name, age, roomOption, numberOfDay);
			hotel.People.Add(person);
			Console.WriteLine("Added!");
		}
		private static Person FindPerson()
		{
			Console.WriteLine("Enter CitizenID:");
			string id = Validation.CheckInputString();
			Person person = hotel.People.Find(p => p.CitizenId.ToLower() == id.ToLower());
			if (person == null)
			{
				Console.WriteLine("Not found!");
				return null;
			}
			person.Show();
			return person;
		}
		public static void CalculateRentAmount()
		{
			Person person = FindPerson();
			if (person != null)
			{
				Console.Write("Rent amount: ");
				Console.WriteLine(hotel.RentAmount(person.CitizenId));
			}
		}
		public static void RemovePerson()
		{
			Person person = FindPerson();
			if (person != null)
			{
				hotel.People.Remove(person);
				Console.WriteLine("Remove!");
			}
		}
	}
}
