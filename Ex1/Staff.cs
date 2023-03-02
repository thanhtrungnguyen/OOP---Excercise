using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex1
{
    class Staff : Officer
    {
        private string _task;
        public Staff(string name, int age, string gender, string address, string task) : base(name, age, gender, address)
        {
            this.Task = task;
        }
        public string Task
        {
            get { return _task; }
            set { _task = value; }
        }
        public override void Show()
        {
            Console.WriteLine("Staff:{" + base.ToString() + ", Task: " + Task + "}");
        }
    }
}
