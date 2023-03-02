using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
	internal class Town
	{
		private List<Family> _families;

		public List<Family> Families
		{
			get { return _families; }
			set { _families = value; }
		}
		public Town()
		{
			this.Families = new List<Family>();
		}

		public void addFamily(Family family)
		{
			this.Families.Add(family);
		}

	}
}
