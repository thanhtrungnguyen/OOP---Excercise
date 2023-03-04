using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
	internal class Manager
	{
		static DocumentManagement documentManagement = new DocumentManagement();
		public static int Menu()
		{
			Console.WriteLine("-------------------------");
			Console.WriteLine("1: Add a document");
			Console.WriteLine("2: Search document by category");
			Console.WriteLine("3: Show document");
			Console.WriteLine("4: Remove document");
			Console.WriteLine("5: Exit");
			Console.WriteLine("Your choice: ");
			int choice = Validation.CheckInputIntLimit(1, 5);
			return choice;
		}

		public static Document CreateDocument()
		{
			Console.WriteLine("Enter ISBN:");
			string isbn = Validation.CheckInputString();
			Console.WriteLine("Enter publisher:");
			string publisher = Validation.CheckInputString();
			Console.WriteLine("Enter circulation:");
			int circulation = Validation.CheckInputIntLimit(0, Int32.MaxValue);
			Document document = new Document(isbn, publisher, circulation);
			return document;
		}

		public static void AddBook()
		{
			Document document = CreateDocument();
			Console.WriteLine("Enter author: ");
			string author = Validation.CheckInputString();
			Console.WriteLine("Enter number of pages:");
			int numberOfPages = Validation.CheckInputIntLimit(0, Int32.MaxValue);
			Book book = new Book(document.ISBN, document.Publisher, document.Circulation, author, numberOfPages);
			documentManagement.Add(book);
		}
		public static void AddJournal()
		{
			Document document = CreateDocument();
			Console.WriteLine("Enter issue number: ");
			int issueNumber = Validation.CheckInputIntLimit(0, Int32.MaxValue);
			Console.WriteLine("Enter issue month:");
			int issueMonth = Validation.CheckInputIntLimit(0, Int32.MaxValue);
			Journal journal = new Journal(document.ISBN, document.Publisher, document.Circulation, issueNumber, issueMonth);
			documentManagement.Add(journal);
		}
		public static void AddNewspaper()
		{
			Document document = CreateDocument();
			Console.WriteLine("Enter day issue:");
			int numberOfPages = Validation.CheckInputIntLimit(0, Int32.MaxValue);
			Newspaper newspaper = new Newspaper(document.ISBN, document.Publisher, document.Circulation, numberOfPages);
			documentManagement.Add(newspaper);
		}

		public static void AddDocument()
		{
			Console.WriteLine("1. Book");
			Console.WriteLine("2. Journal");
			Console.WriteLine("3. Newspaper");
			Console.WriteLine("Your choice: ");
			int choice = Validation.CheckInputIntLimit(1, 3);
			switch (choice)
			{
				case 1:
					AddBook();
					break;
				case 2:
					AddJournal();
					break;
				case 3:
					AddNewspaper();
					break;
			}
		}

		public static void SearchByCategory()
		{
			Console.WriteLine("1. Book");
			Console.WriteLine("2. Journal");
			Console.WriteLine("3. Newspaper");
			Console.WriteLine("Your choice: ");
			int choice = Validation.CheckInputIntLimit(1, 3);
			switch (choice)
			{
				case 1:
					documentManagement.SearchBook();
					break;
				case 2:
					documentManagement.SearchJournal();
					break;
				case 3:
					documentManagement.SearchNewspaper();
					break;
			}
		}

		public static void ShowDocument()
		{
			documentManagement.ShowDocuments();
		}
		public static void RemoveDocument()
		{
			Console.WriteLine("Enter ISBN that you want to remove:");
			string isbn = Validation.CheckInputString();
			documentManagement.RemoveDocument(isbn);
		}

	}
}
