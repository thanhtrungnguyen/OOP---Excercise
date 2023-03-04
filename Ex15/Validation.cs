using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    internal class Validation
    {
        private const int defautFirstOption = 1;
        public static int CheckInputIntLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine().Trim());
                    if (input < min || input > max)
                    {
                        throw new FormatException();
                    }
                    return input;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, input must be in range {0} - {1}!", min, max);
                    Console.WriteLine("Enter again: ");
                }
            }
        }

        public static float CheckInputFloatLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    float input = float.Parse(Console.ReadLine().Trim(), CultureInfo.InvariantCulture.NumberFormat);
                    if (input < min || input > max)
                    {
                        throw new FormatException();
                    }
                    return input;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, input must be in range {0} - {1}!", min, max);
                    Console.WriteLine("Enter again: ");
                }
            }
        }

        public static int CheckOption(int max)
        {
            while (true)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine().Trim());
                    if (input < defautFirstOption || input > max)
                    {
                        throw new FormatException();
                    }
                    return input - defautFirstOption;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, input must be in range {0} - {1}!", defautFirstOption, max);
                    Console.WriteLine("Enter again: ");
                }
            }
        }

        public static string CheckInputString()
        {
            while (true)
            {
                string input = Console.ReadLine().Trim();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                Console.WriteLine("Invalid format, input must be not Null Or White Space");
                Console.WriteLine("Enter again:");
            }
        }

        public static bool CheckInputBoolean()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "y") { return true; }
                if (input == "n") { return false; }
                Console.WriteLine("Invalid format, input must be y or n");
                Console.WriteLine("Enter again:");
            }
        }

        public static DateTime CheckInputDate()
        {
            while (true)
            {
                try
                {
                    string enteredString = Console.ReadLine().Trim();
                    DateTime enteredDate = DateTime.ParseExact(enteredString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    return enteredDate;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid format, dd/MM/yyyy is require!");
                    Console.WriteLine("Enter again:");
                }
            }
        }
    }
}
