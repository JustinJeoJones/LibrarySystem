using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogSystem.Library
{
    public class Catalog
    {
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
                Console.WriteLine($"{book.GetBookId()}\t{book.GetTitle()}\t{book.GetAuthor()}\t{book.GetCheckedOut()}");
            }
        }

        public void SearchLibraryCatalogByTitle(string title)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetTitle() == title)
                {
                    Console.WriteLine($"{book.GetBookId()}\t{book.GetTitle()}\t{book.GetAuthor()}\t{book.GetCheckedOut()}");
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
                    Console.WriteLine($"{book.GetBookId()}\t{book.GetTitle()}\t{book.GetAuthor()}\t{book.GetCheckedOut()}");
                }
            }
        }

        public void SearchLibraryCatalogByCheckedOut(bool checkout)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetCheckedOut() == checkout)
                {
                    Console.WriteLine($"{book.GetBookId()}\t{book.GetTitle()}\t{book.GetAuthor()}\t{book.GetCheckedOut()}");
                }
            }
        }

        public void SaveLibrary()
        {
            throw new NotImplementedException();
        }

    }
}