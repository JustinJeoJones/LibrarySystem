using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogSystem.Library
{
    public class Catalog
    {
        public static string formatOutput = "{0, -15} {1, -40} {2, -20} {3, -20}";
        public Catalog()
        {
            libraryCatalog = new List<Book>(); 
        }
        public List<Book> libraryCatalog { get; set; }

        public void LoadLibrary()
        {
            throw new NotImplementedException();
        }


        public void ListBooksInLibraryCatalog()
        {
            foreach (Book book in libraryCatalog)
            {
                Console.WriteLine(formatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetCheckedOut());
            }
        }

        public void SearchLibraryCatalogByTitle(string title)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetTitle() == title)
                {
                    Console.WriteLine(formatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetCheckedOut());
                }
            }
        }

        public List<Book> SearchLibraryCatalogByKeyword(string keyword)
        {
            var matches = libraryCatalog.Where(book => book.GetTitle().Contains(keyword));
            return matches.ToList();
        }

        public void SearchLibraryCatalogByAuthor(string author)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetAuthor() == author)
                {
                    Console.WriteLine(formatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetCheckedOut());
                }
            }
        }

        public void SearchLibraryCatalogByCheckedOut(bool checkout)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetCheckedOut() == checkout)
                {
                    Console.WriteLine(formatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetCheckedOut());
                }
            }
        }

        public void SaveLibrary()
        {
            throw new NotImplementedException();
        }

    }
}