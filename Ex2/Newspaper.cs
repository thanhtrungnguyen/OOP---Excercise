using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Newspaper : Document
    {
        private int _dayIssue;

        public int DayIssue
        {
            get { return _dayIssue; }
            set { _dayIssue = value; }
        }

        public Newspaper(string isbn, string publisher, int circulation, int dayIssue) : base(isbn, publisher, circulation)
        {
            this.DayIssue = dayIssue;
        }
        public override void Show()
        {
            Console.WriteLine("Book:{" + base.ToString() + ", DayIssue: " + DayIssue + "}");
        }
    }
}
