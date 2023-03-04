using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

		private float _entryPoint;

		public float EntryPoint
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

		public Student(string id, string fullname, DateTime birthDate, int startYear, float entryPoint, List<MarkReport> markReports)
		{
			this.ID = id;
			this.Fullname = fullname;
			this.BirthDate = birthDate;
			this.StartYear = startYear;
			this.EntryPoint = entryPoint;
			this.MarkReports = markReports;
		}


		public override string ToString()
		{
			string combinedString = string.Empty;
			MarkReports.ForEach(mr => { combinedString += mr.ToString(); });
			return string.Format("ID: {0}, \nName: {1}, \nBirthDate: {2}, \nStartYear: {3}, \nEntryPoint: {4}, \nMarkReports: [\n{6}]", ID, Fullname, BirthDate, StartYear, EntryPoint, combinedString);
		}

		public virtual void Show()
		{
			Console.WriteLine("RegularStudent: {{{0}}}", this.ToString());
		}

	}
}
