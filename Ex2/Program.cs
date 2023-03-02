using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
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
                        Manager.AddDocument();
                        break;
                    case 2:
                        Manager.SearchByCategory();
                        break;
                    case 3:
                        Manager.ShowDocument();
                        break;
                    case 4:
                        Manager.RemoveDocument();
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
