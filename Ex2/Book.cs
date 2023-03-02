using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Book : Document
    {
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private int _numberOfPages;

        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }


        public Book(string isbn, string publisher, int circulation, string author, int numberOfPages) : base(isbn, publisher, circulation)
        {
            this.Author = author;
            this.NumberOfPages = numberOfPages;
        }

        public override void Show()
        {
            Console.WriteLine("Book:{" + base.ToString() + ", Author: " + Author + ", Number of pages: " + NumberOfPages + "}");
        }
    }
}
