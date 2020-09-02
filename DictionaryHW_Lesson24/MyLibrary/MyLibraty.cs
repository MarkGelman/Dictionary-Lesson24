using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class MyLibraty
    {
        private Dictionary<string, Book> books;
        private int _count = 0;
        public MyLibraty()
        {

        }

        public int Count
        {
            get
            {
                return _count++;
            }
        }
        public bool AddBook (Book book)
        {
            if (!books.ContainsKey(book.Title))
            {
                books.Add(book.Title, book);
                return true;
            }   
            else
                return false;
        }

        public bool RemoveBook(Book book)
        {
            if (books.ContainsKey(book.Title))
            {
                books.Remove(book.Title);
                return true;
            }
            else
                return false;
        }

        public bool HaveThisBook (Book book)
        {
            if (books.ContainsKey(book.Title))
            {
                return true;
            }
            else
                return false;
        }

        public Book GetBook (string title)
        {
            foreach (KeyValuePair<string,Book> item in books)
            {
                if (item.Key == title)
                    return item.Value;
            }
            return null;
        }

        public Book GetBookByAuthor (string author)
        {
            foreach (KeyValuePair<string, Book> item in books)
            {
                if (item.Value.Author == author)
                    return item.Value;
            }
            return null;
        }

        public void Clear ()
        {
            books.Clear();
        }

        public List <string> GetAuthors ()
        {

            return
        }

        public List<Book> GetBooksSortedByAuthorName()
        {
            return;
        }

        public List<string> GetBooksTitleSorted()
        {
            return;
        }

        public override string ToString()
        {
            foreach (KeyValuePair<string,Book> item in books)
            {
                Console.WriteLine($"Title: {item.Value.Author}\nContent: {item.Value.Content}");
                Console.WriteLine();
                Console.WriteLine("=====================================================================");
                Console.WriteLine();
            }
            return base.ToString();
        }
    }
}
