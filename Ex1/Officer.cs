using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Officer
    {
        private string _name;
        private int _age;
        private string _gender;
        private string _address;

        public Officer(string name, int age, string gender, string address)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Gender: " + Gender + ", Address: " + Address;
        }
        public virtual void Show()
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age + ", Gender: " + Gender + ", Address: " + Address);
        }

    }

}
