using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
	internal class Person
	{
		private string _citizenID;

		public string CitizenID
		{
			get { return _citizenID; }
			set { _citizenID = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _age;

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}
		private string _job;

		public string Job
		{
			get { return _job; }
			set { _job = value; }
		}
		public Person(string citizenID, string name, int age, string job)
		{
			this.CitizenID = citizenID;
			this.Name = name;
			this.Age = age;
			this.Job = job;
		}

		public override string ToString()
		{
			return "CitizenID: " + CitizenID + ", Name: " + Name + ", Age: " + Age + ", Job: " + Job;
		}
		public virtual void Show()
		{
			Console.WriteLine("Person");
		}

	}
}
