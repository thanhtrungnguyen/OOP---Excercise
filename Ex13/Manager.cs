using Ex13.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Manager
    {

        public enum EmployeeType
        {
            Intern,
            Fresher,
            Experience
        }
        public enum MenuOption
        {
            ListAll,
            ListByType,
            Add,
            Update,
            Exit
        }

        private static List<Employee> employees = new List<Employee>();

        public static void AddSampleData()
        {
            DateTime dateSample = new DateTime(2008, 6, 1, 7, 47, 0);
            Certificate certificateSample1 = new Certificate("CE01", "Certificate A", "B", dateSample);
            Certificate certificateSample2 = new Certificate("CE02", "Certificate B", "A", dateSample);
            Certificate certificateSample3 = new Certificate("CE03", "Certificate C", "F", dateSample);
            List<Certificate> certificatesSample1 = new List<Certificate>
            {
                certificateSample1
            };
            List<Certificate> certificatesSample2 = new List<Certificate> {
                certificateSample1, certificateSample2
            };
            List<Certificate> certificatesSample3 = new List<Certificate> {
                certificateSample1, certificateSample2, certificateSample3, certificateSample3
            };
            Employee employeeSample1 = new Intern("EM01", "Mr A", dateSample, "0987654321", "aasdfsd@gmail.com", certificatesSample1, "SE", 7, "University A");
            Employee employeeSample2 = new Fresher("EM02", "Mr B", dateSample, "0987654321", "aasdfsd@gmail.com", certificatesSample2, dateSample, "Rank 10", "University B");
            Employee employeeSample3 = new Experience("EM03", "Mr B", dateSample, "0987654321", "aasdfsd@gmail.com", certificatesSample3, 5, "Skill A");
            employees.Add(employeeSample1);
            employees.Add(employeeSample2);
            employees.Add(employeeSample3);
        }

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("=====================================================================");
                Console.WriteLine("1: Show list employees");
                Console.WriteLine("2: Show employees by type");
                Console.WriteLine("3: Add an employee");
                Console.WriteLine("4: Update an employee");
                Console.WriteLine("5: Exit");
                Console.WriteLine("Your choice: ");
                MenuOption option = (MenuOption)Validation.CheckOption(Enum.GetNames(typeof(MenuOption)).Length);
                switch (option)
                {
                    case MenuOption.ListAll:
                        ListAll();
                        break;
                    case MenuOption.ListByType:
                        ListByType();
                        break;
                    case MenuOption.Add:
                        Add();
                        break;
                    case MenuOption.Update:
                        Update();
                        break;
                    case MenuOption.Exit:
                        return;
                }
            }
        }
        public static void ListAll()
        {
            Console.WriteLine("List employees:");
            employees.ForEach(employee => employee.Show());
        }
        private static EmployeeType ChooseEmployeeType()
        {
            Console.WriteLine("Choose type:\n1. Intern\n2. Fresher\n3. Experience\nEnter type:");
            EmployeeType type = (EmployeeType)Validation.CheckOption(Enum.GetNames(typeof(EmployeeType)).Length);
            return type;
        }
        public static void ListByType()
        {
            switch (ChooseEmployeeType())
            {
                case EmployeeType.Intern:
                    employees.ForEach(employee => { if (employee.GetType() == typeof(Intern)) employee.Show(); });
                    break;
                case EmployeeType.Fresher:
                    employees.ForEach(employee => { if (employee.GetType() == typeof(Fresher)) employee.Show(); });
                    break;
                case EmployeeType.Experience:
                    employees.ForEach(employee => { if (employee.GetType() == typeof(Experience)) employee.Show(); });
                    break;
            }
        }

        private static void Add()
        {
            switch (ChooseEmployeeType())
            {
                case EmployeeType.Intern:
                    AddIntern();
                    break;
                case EmployeeType.Fresher:
                    AddFresher();
                    break;
                case EmployeeType.Experience:
                    AddExperience();
                    break;
            }
        }
        private static Employee CreateEmployee()
        {
            Console.WriteLine("Enter Employee ID:");
            string id = Validation.CheckInputString();
            Console.WriteLine("Enter Employee name:");
            string name = Validation.CheckInputString();
            Console.WriteLine("Enter Employee BirthDate:");
            DateTime birthDate = Validation.CheckInputDate();
            Console.WriteLine("Enter Employee phone:");
            string phone = Validation.CheckInputString();
            Console.WriteLine("Enter Employee email:");
            string email = Validation.CheckInputString();
            Console.WriteLine("Enter certificates:");
            List<Certificate> certificates = CreateCertificates();
            Employee employee = new Employee(id, name, birthDate, phone, email, certificates);
            return employee;
        }
        private static List<Certificate> CreateCertificates()
        {
            List<Certificate> certificates = new List<Certificate>();
            while (true)
            {
                Console.WriteLine("Enter Certificate ID:");
                string id = Validation.CheckInputString();
                Console.WriteLine("Enter Certificate name:");
                string name = Validation.CheckInputString();
                Console.WriteLine("Enter Certificate rank:");
                string rank = Validation.CheckInputString();
                Console.WriteLine("Enter Certificate date:");
                DateTime date = Validation.CheckInputDate();
                Certificate certificate = new Certificate(id, name, rank, date);
                certificates.Add(certificate);
                Console.WriteLine("Continue?[y/n]");
                bool option = Validation.CheckInputBoolean();
                if (!option) { return certificates; }
            }
        }

        private static void AddExperience()
        {
            Employee employee = CreateEmployee();
            Console.WriteLine("Enter YearOfExperience:");
            int yearOfExperience = Validation.CheckInputIntLimit(1, 1000);
            Console.WriteLine("Enter Skill:");
            string skill = Validation.CheckInputString();
            Employee experience = new Experience(employee.ID, employee.Name, employee.BirthDate, employee.Phone, employee.Email, employee.Certificates, yearOfExperience, skill);
            employees.Add(experience);
            Console.WriteLine("Added!");
        }

        private static void AddFresher()
        {
            Employee employee = CreateEmployee();
            Console.WriteLine("Enter GraduationDate:");
            DateTime graduationDate = Validation.CheckInputDate();
            Console.WriteLine("Enter GraduationRank:");
            string graduationRank = Validation.CheckInputString();
            Console.WriteLine("Enter UniversityName:");
            string universityName = Validation.CheckInputString();
            Employee experience = new Fresher(employee.ID, employee.Name, employee.BirthDate, employee.Phone, employee.Email, employee.Certificates, graduationDate, graduationRank, universityName);
            employees.Add(experience);
            Console.WriteLine("Added!");
        }

        private static void AddIntern()
        {
            Employee employee = CreateEmployee();
            Console.WriteLine("Enter major:");
            string major = Validation.CheckInputString();
            Console.WriteLine("Enter semester:");
            int semester = Validation.CheckInputIntLimit(1, 100);
            Console.WriteLine("Enter UniversityName:");
            string universityName = Validation.CheckInputString();
            Employee experience = new Intern(employee.ID, employee.Name, employee.BirthDate, employee.Phone, employee.Email, employee.Certificates, major, semester, universityName);
            employees.Add(experience);
            Console.WriteLine("Added!");
        }

        private static void Update()
        {
            switch (ChooseEmployeeType())
            {
                case EmployeeType.Intern:
                    UpdateIntern();
                    break;
                case EmployeeType.Fresher:
                    UpdateFresher();
                    break;
                case EmployeeType.Experience:
                    UpdateExperience();
                    break;
            }
        }

        private static void UpdateExperience()
        {
            throw new NotImplementedException();
        }

        private static void UpdateFresher()
        {
            throw new NotImplementedException();
        }

        private static void UpdateIntern()
        {
            throw new NotImplementedException();
        }
    }
}
