using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
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
                        Manager.AddOfficer();
                        break;
                    case 2:
                        Manager.SearchOfficers();
                        break;
                    case 3:
                        Manager.ShowList();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
