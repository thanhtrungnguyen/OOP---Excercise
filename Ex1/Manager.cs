using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Manager
    {
        static OfficerManagement officerManagement = new OfficerManagement();
        public static int Menu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1: Add an officer");
            Console.WriteLine("2: Search officers by name");
            Console.WriteLine("3: Show officers infomation");
            Console.WriteLine("4: Exit");
            Console.WriteLine("Your choice:");
            int choice = Validation.CheckInputIntLimit(1, 4);
            return choice;
        }

        public static void AddOfficer()
        {
            Console.WriteLine("Enter name:");
            string name = Validation.CheckInputString();
            Console.WriteLine("Enter age:");
            int age = Validation.CheckInputIntLimit(0, 200);
            Console.WriteLine("Enter gender:");
            string gender = Validation.CheckInputString();
            Console.WriteLine("Enter address:");
            string address = Validation.CheckInputString();
            Console.WriteLine("Choose officer type:\n1: Enginner\n2: Worker\n3: Staff");
            int type = Validation.CheckInputIntLimit(1, 3);
            switch (type)
            {
                case 1:
                    Console.WriteLine("Enter branch:");
                    string branch = Validation.CheckInputString();
                    Officer engineer = new Engineer(name, age, gender, address, branch);
                    officerManagement.AddOfficer(engineer);
                    break;
                case 2:
                    Console.WriteLine("Enter worker:");
                    int level = Validation.CheckInputIntLimit(1, 10);
                    Officer worker = new Worker(name, age, gender, address, level);
                    officerManagement.AddOfficer(worker);
                    break;
                case 3:
                    Console.WriteLine("Enter staff:");
                    string task = Validation.CheckInputString();
                    Officer staff = new Engineer(name, age, gender, address, task);
                    officerManagement.AddOfficer(staff);
                    break;
            }
            Console.WriteLine("Added!");
        }

        public static void SearchOfficers()
        {
            Console.WriteLine("Enter name:");
            string name = Validation.CheckInputString();
            officerManagement.SearchOfficer(name);
        }

        public static void ShowList()
        {
            Console.WriteLine("List:");
            officerManagement.ShowOfficers();
        }


    }
}
