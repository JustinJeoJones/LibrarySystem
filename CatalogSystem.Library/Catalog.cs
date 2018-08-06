using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogSystem.Library
{
    public class Catalog
    {
        public static string FormatOutput = "{0, -15} {1, -40} {2, -20} {3, -20}";
        public Catalog()
        {
            libraryCatalog = new List<Book>();
        }

        public List<Book> libraryCatalog { get; set; }


        public void ListBooksInLibraryCatalog()
        {
            foreach (Book book in libraryCatalog)
            {
                Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetCheckedOut());
            }
        }

        public void SearchLibraryCatalogByTitle(string title)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetTitle() == title)
                {
                    Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetCheckedOut());
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
                    Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetCheckedOut());
                }
            }
        }

        public void SearchLibraryCatalogByCheckedOut(bool checkout)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetCheckedOut() == checkout)
                {
                    Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), book.GetCheckedOut());
                }
            }
        }
        //public void AddBookToCatalog()
        //{
        //    string newBookTitle;
        //    string newBookAuthor;
        //    do
        //    {
        //        Console.WriteLine("Please enter the title of the book to be added");
        //        newBookTitle = Console.ReadLine();
        //    } while (string.IsNullOrWhiteSpace(newBookTitle));

        //    do
        //    {
        //        Console.WriteLine("Please enter the author of that book");
        //        newBookAuthor = Console.ReadLine();
        //    } while (string.IsNullOrWhiteSpace(newBookAuthor));
        //}

    }
}