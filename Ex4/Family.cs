using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
	internal class Family
	{
		private List<Person> _people;

		public List<Person> People
		{
			get { return _people; }
			set { _people = value; }
		}

		private string _address;

		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}
		public Family()
		{
			People = new List<Person>();

		}
		public Family(List<Person> people, string address)
		{
			this.People = people;
			this.Address = address;
		}

		public void AddPerson(Person person)
		{
			this.People.Add(person);
		}

		public override string ToString()
		{
			return "Family:{Peo}";
		}

	}
}
