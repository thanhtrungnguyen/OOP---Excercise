using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Manager
    {
        public static Town town = new Town();
        public static int Menu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1: Show families");
            Console.WriteLine("2: Add a family");
            Console.WriteLine("3: Exit");
            Console.WriteLine("Your choice: ");
            int choice = Validation.CheckInputIntLimit(1, 3);
            return choice;
        }
        public static void AddFamily()
        {
            Family family = new Family();
            town.addFamily(family);
            Console.WriteLine("Enter address:");
            string address = Validation.CheckInputString();
            family.Address = address;
            while (true)
            {
                Console.WriteLine("Enter citizen ID:");
                string citizenId = Validation.CheckInputString();
                Console.WriteLine("Enter name:");
                string name = Validation.CheckInputString();
                Console.WriteLine("Enter age:");
                int age = Validation.CheckInputIntLimit(0, 999);
                Console.WriteLine("Enter job:");
                string job = Validation.CheckInputString();
                Person person = new Person(citizenId, name, age, job);
                family.AddPerson(person);
                Console.WriteLine("Continue?[y/n]");
                bool option = Validation.CheckInputBoolean();
                if (!option) { return; }
            }


        }
        public static void ShowFamilies()
        {
            foreach (Family family in town.Families)
            {
                Console.WriteLine("_________");
                foreach (Person person in family.People)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine("Address: " + family.Address);
            }
        }
    }
}
