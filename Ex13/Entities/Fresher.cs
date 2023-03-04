using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entities
{
    internal class Fresher : Employee
    {
        private DateTime _graduationDate;

        public DateTime GraduationDate
        {
            get { return _graduationDate; }
            set { _graduationDate = value; }
        }
        private string _graduationRank;

        public string GraduationRank
        {
            get { return _graduationRank; }
            set { _graduationRank = value; }
        }
        private string _universityName;

        public string UniversityName
        {
            get { return _universityName; }
            set { _universityName = value; }
        }
        public Fresher(string id, string name, DateTime birthDate, string phone, string email, List<Certificate> certificates, DateTime graduationDate, string graduationRank, string universityName) : base(id, name, birthDate, phone, email, certificates)
        {
            this.GraduationDate = graduationDate;
            this.GraduationRank = graduationRank;
            this.UniversityName = universityName;
        }
        public override void Show()
        {
            Console.WriteLine("------------\nFresher:{{\n{0}, \nGraduationDate: {1}, \nGraduationRank: {2}, \nUniversityName: {3}\n}}", base.ToString(), GraduationDate, GraduationRank, UniversityName);
        }
    }
}
