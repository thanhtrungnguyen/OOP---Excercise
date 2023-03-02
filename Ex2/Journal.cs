using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Journal : Document
    {
        private int _issueNumber;

        public int IssueNumber
        {
            get { return _issueNumber; }
            set { _issueNumber = value; }
        }

        private int _monthIssue;

        public int MonthIssue
        {
            get { return _monthIssue; }
            set { _monthIssue = value; }
        }


        public Journal(string isbn, string publisher, int circulation, int issueNumber, int monthIssue) : base(isbn, publisher, circulation)
        {
            this.IssueNumber = issueNumber;
            this.MonthIssue = monthIssue;
        }

        public override void Show()
        {
            Console.WriteLine("Book:{" + base.ToString() + ", IssueNumber: " + IssueNumber + ", MonthIssue: " + MonthIssue + "}");
        }
    }
}
