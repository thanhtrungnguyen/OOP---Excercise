using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entities
{
    internal class Experience : Employee
    {
        private int _yearOfExperience;

        public int YearOfExperience
        {
            get { return _yearOfExperience; }
            set { _yearOfExperience = value; }
        }
        private string _skill;

        public string Skill
        {
            get { return _skill; }
            set { _skill = value; }
        }


        public Experience(string id, string name, DateTime birthDate, string phone, string email, List<Certificate> certificates, int yearOfExperience, string skill) : base(id, name, birthDate, phone, email, certificates)
        {
            this.YearOfExperience = yearOfExperience;
            this.Skill = skill;
        }

        public override void Show()
        {
            Console.WriteLine("------------\nExperience:{{\n{0}, \nYearOfExperience: {1}, \nSkill: {2}\n}}", base.ToString(), YearOfExperience, Skill);
        }
    }
}
