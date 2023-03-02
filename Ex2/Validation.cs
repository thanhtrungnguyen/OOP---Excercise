using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Validation
    {
        public static int CheckInputIntLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input < min || input > max)
                    {
                        throw new FormatException();
                    }
                    return input;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter again: ");
                }
            }
        }

        public static string CheckInputString()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                Console.WriteLine("Enter again:");
            }
        }
    }
}
