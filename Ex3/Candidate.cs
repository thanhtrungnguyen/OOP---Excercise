using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
	internal class Candidate
	{
		private string _id;

		public string ID
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _address;

		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		private int _priority;

		public int Priority
		{
			get { return _priority; }
			set { _priority = value; }
		}
		public Candidate(string id, string name, string address, int priority)
		{
			this.ID = id;
			this.Name = name;
			this.Address = address;
			this.Priority = priority;
		}
		public override string ToString()
		{
			return "ID: " + ID + ", Name: " + Name + ", Address:" + Address + ", Priority" + Priority;
		}
		public virtual void Show()
		{
			Console.WriteLine("Candidate");
		}


	}
}
