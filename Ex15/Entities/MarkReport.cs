using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entities
{
	internal class MarkReport
	{
		private string _semesterName;

		public string SemesterName
		{
			get { return _semesterName; }
			set { _semesterName = value; }
		}

		private float _averageMark;

		public float AverageMark
		{
			get { return _averageMark; }
			set { _averageMark = value; }
		}
		public MarkReport(string semesterName, float averageMark)
		{
			this.SemesterName = semesterName;
			this.AverageMark = averageMark;
		}

		public override string ToString()
		{
			return string.Format("MarkReport:{{Semester: {0}, AverageMark: {1}}}", SemesterName, AverageMark);
		}

	}
}
