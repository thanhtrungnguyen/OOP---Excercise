using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Engineer : Officer
    {
        private string _branch;
        public Engineer(string name, int age, string gender, string address, string branch) : base(name, age, gender, address)
        {
            this.Branch = branch;
        }
        public string Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }
        public override void Show()
        {
            Console.WriteLine("Engineer:{" + base.ToString() + ", Branch: " + Branch + "}");
        }
    }
}
