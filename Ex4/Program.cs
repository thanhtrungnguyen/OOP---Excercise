using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = Manager.Menu();
                switch (choice)
                {
                    case 1:
                        Manager.ShowFamilies();
                        break;
                    case 2:
                        Manager.AddFamily();
                        break;
                    case 3:
                        return;
                }
            }

        }
    }
}
