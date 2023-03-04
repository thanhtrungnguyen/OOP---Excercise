using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
	internal class Room
	{
		private string _category;

		public string Categoty
		{
			get { return _category; }
			set { _category = value; }
		}
		private float _price;

		public float Price
		{
			get { return _price; }
			set { _price = value; }
		}
		public Room(string category, float price)
		{
			this.Categoty = category;
			this.Price = price;
		}


	}
}
