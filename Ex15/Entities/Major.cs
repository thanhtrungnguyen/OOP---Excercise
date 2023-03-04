using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entities
{
	internal class Major
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private List<Student> _students;

		public List<Student> Students
		{
			get { return _students; }
			set { _students = value; }
		}

		public Major(string name)
		{
			this.Name = name;
			this.Students = new List<Student>();
		}

		public void AddStudent(Student student)
		{
			this.Students.Add(student);
		}

		public void ShowHighestMarkStudent() { }
		public void ShowHighestEntryPointStudent() { }

	}
}
