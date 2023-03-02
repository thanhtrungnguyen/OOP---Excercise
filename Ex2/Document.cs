using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
	internal class Document
	{

		private string _isbn;
		private string _publisher;
		private int _circulation;
		public Document(string isbn, string publisher, int circulation)
		{
			this.ISBN = isbn;
			this.Publisher = publisher;
			this.Circulation = circulation;
		}
		public string ISBN
		{
			get { return _isbn; }
			set { _isbn = value; }
		}
		public string Publisher
		{
			get { return _publisher; }
			set { _publisher = value; }
		}
		public int Circulation
		{
			get { return _circulation; }
			set { _circulation = value; }
		}
		public override string ToString() { return "ISBN: " + ISBN + ", Publisher: " + Publisher + ", Circulation: " + Circulation; }
		public virtual void Show()
		{
			Console.WriteLine();
		}

	}
}
