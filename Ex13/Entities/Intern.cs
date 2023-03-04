using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entities
{
    internal class Intern : Employee
    {
        private string _major;

        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }
        private int _semester;

        public int Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }
        private string _universityName;

        public string UniversityName
        {
            get { return _universityName; }
            set { _universityName = value; }
        }
        public Intern(string id, string name, DateTime birthDate, string phone, string email, List<Certificate> certificates, string major, int semester, string universityName) : base(id, name, birthDate, phone, email, certificates)
        {
            this.Major = major;
            this.Semester = semester;
            this.UniversityName = universityName;
        }
        public override void Show()
        {
            Console.WriteLine("------------\nIntern:{{\n{0}, \nMajor: {1}, \nSemester: {2}, \nUniversityName: {3}\n}}", base.ToString(), Major, Semester, UniversityName);
        }
    }
}
