using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
	internal class Person
	{
		private string _citizenId;

		public string CitizenId
		{
			get { return _citizenId; }
			set { _citizenId = value; }
		}
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private Room _room;
		private int _age;

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}

		public Room Room
		{
			get { return _room; }
			set { _room = value; }
		}
		private int _numberOfDay;

		public int NumberOfDay
		{
			get { return _numberOfDay; }
			set { _numberOfDay = value; }
		}
		public Person(string citizenId, string name, int age, Room room, int numberOfDay)
		{
			this.CitizenId = citizenId;
			this.Name = name;
			this.Age = age;
			this.Room = room;
			this.NumberOfDay = numberOfDay;
		}
		public void Show()
		{
			Console.WriteLine("Person:{CitizenID: " + CitizenId + ", Name:" + Name + ", Room: " + Room.Categoty + ", NumberOfDay:" + NumberOfDay + "}");
		}

	}
}
