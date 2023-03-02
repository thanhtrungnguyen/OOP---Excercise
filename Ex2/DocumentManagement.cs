using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class DocumentManagement
    {
        List<Document> documents;
        public DocumentManagement()
        {
            documents = new List<Document>();
        }
        public void Add(Document document)
        {
            documents.Add(document);
        }
        public void RemoveDocument(string isbn)
        {
            Document document = documents.Find(doc => doc.ISBN == isbn);
            if (document != null)
            {
                document.Show();
                documents.Remove(document);
                Console.WriteLine("The document deleted!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
        public void ShowDocuments()
        {
            foreach (Document document in documents)
            {
                document.Show();
            }
        }
        public void SearchBook()
        {
            foreach (Document document in documents)
            {
                if (document.GetType() == typeof(Book))
                {
                    document.Show();
                }
            }
        }
        public void SearchJournal()
        {
            foreach (Document document in documents)
            {
                if (document.GetType() == typeof(Journal))
                {
                    document.Show();
                }
            }
        }
        public void SearchNewspaper()
        {
            foreach (Document document in documents)
            {
                if (document.GetType() == typeof(Newspaper))
                {
                    document.Show();
                }
            }
        }
    }
}
