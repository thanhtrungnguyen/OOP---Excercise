using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Worker : Officer
    {
        private int _level;
        public Worker(string name, int age, string gender, string address, int level) : base(name, age, gender, address)
        {
            this.Level = level;
        }
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public override void Show()
        {
            Console.WriteLine("Worker:{" + base.ToString() + ", Level: " + Level + "}");
        }
    }
}
