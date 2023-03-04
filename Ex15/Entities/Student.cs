using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entities
{
	internal class Student
	{
		private string _id;

		public string ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _fullname;

		public string Fullname
		{
			get { return _fullname; }
			set { _fullname = value; }
		}

		private DateTime _birthDate;

		public DateTime BirthDate
		{
			get { return _birthDate; }
			set { _birthDate = value; }
		}

		private int _startYear;

		public int StartYear
		{
			get { return _startYear; }
			set { _startYear = value; }
		}

		private string _entryPoint;

		public string EntryPoint
		{
			get { return _entryPoint; }
			set { _entryPoint = value; }
		}

		private List<MarkReport> _markReports;

		public List<MarkReport> MarkReports
		{
			get { return _markReports; }
			set { _markReports = value; }
		}

		public Student(string id, string fullname, DateTime birthDate, int startYear, List<MarkReport> markReports)
		{
			this.ID = id;
			this.Fullname = fullname;
			this.BirthDate = birthDate;
			this.StartYear = startYear;
			this.MarkReports = markReports;
		}

	}
}
