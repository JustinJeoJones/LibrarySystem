﻿using System;
using System.Collections.Generic;

namespace CatalogSystem.Library
{
    public class Catalog
    {
        public Catalog()
        {
            libraryCatalog = new List<Book>();
        }
        public List<Book> libraryCatalog { get; set; }
        public void PopulateBooksToLibraryCatalog()
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

        public void SearchLibraryCatalogByKeyword(string keyword)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetTitle().Contains(keyword))
                {
                    Console.WriteLine($"{book.GetBookId()}\t{book.GetTitle()}\t{book.GetAuthor()}\t{book.GetCheckedOut()}");
                }
            }
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

        public void SaveLibraryCatalogToFIle()
        {
            throw new NotImplementedException();
        }

    }
}