using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int option = Manager.Menu();
                switch (option)
                {
                    case 1:
                        Manager.ShowPeople();
                        break;
                    case 2:
                        Manager.AddPerson();
                        break;
                    case 3:
                        Manager.CalculateRentAmount();
                        break;
                    case 4:
                        Manager.RemovePerson();
                        break;
                    case 5:
                        return;
                }
            }

        }
    }
}
