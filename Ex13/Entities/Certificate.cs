using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entities
{
	internal class Certificate
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
		private string _rank;

		public string Rank
		{
			get { return _rank; }
			set { _rank = value; }
		}
		private DateTime _date;

		public DateTime Date
		{
			get { return _date; }
			set { _date = value; }
		}
		public Certificate(string id, string name, string rank, DateTime date)
		{
			this.ID = id;
			this.Name = name;
			this.Rank = rank;
			this.Date = date;
		}
		public override string ToString()
		{
			return string.Format("Certificate: {{ID: {0}, Name: {1}, Rank: {2}, Date: {3}}}\n", ID, Name, Rank, Date);
		}
	}
}
