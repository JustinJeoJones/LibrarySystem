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

        public static string longLine = "==========================================================================================================================";
        public static string FormatOutput = "{0, -15} {1, -40} {2, -20} {3, -20} {4, -20}";

        //Get the generic list of books from the Catalog class and print out the books to the console
        public void ListBooksInLibraryCatalog()
        {
            //iterate through the list and determine whether or not it's on the shelf
            foreach (Book book in libraryCatalog)
            {
                string onShelf;

                if (book.GetCheckedOut())
                {
                    onShelf = "Checked Out";
                }
                else
                {
                    onShelf = "On Shelf";
                }
                //Write the book information onto the console.
                Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), onShelf, book.GetDueDate());
            }
            Console.WriteLine(longLine);
        }

        //Currently unipmlemented but this function is a "SEARCH BY EXACT TITLE"
        //sort of method that only prints out books to the console that match the search term exactly
        public void SearchLibraryCatalogByTitle(string title)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetTitle() == title)
                {
                    string onShelf;

                    if (book.GetCheckedOut())
                    {
                        onShelf = "Checked Out";
                    }
                    else
                    {
                        onShelf = "On Shelf";
                    }

                    Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), onShelf);
                }
            }
            Console.WriteLine(longLine);
        }

        //This method prints out all books in the
        //generic list of books that contain the keyword specified in their title
        public void SearchLibraryCatalogByKeyword(string keyword)
        {
             foreach (Book book in libraryCatalog)
            {
                if (book.GetTitle().Contains(keyword))
                {
                    string onShelf;

                    if (book.GetCheckedOut())
                    {
                        onShelf = "Checked Out";
                    }
                    else
                    {
                        onShelf = "On Shelf";
                    }

                    Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), onShelf, book.GetDueDate());
                }
            }
            Console.WriteLine(longLine);
        }

        //Method to search for the author keyword within the author property on the book instance
        public void SearchLibraryCatalogByAuthor(string author)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetAuthor().Contains(author))
                {
                    string onShelf;

                    if (book.GetCheckedOut())
                    {
                        onShelf = "Checked Out";
                    }
                    else
                    {
                        onShelf = "On Shelf";
                    }

                    Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), onShelf, book.GetDueDate());
                }
            }
            Console.WriteLine(longLine);
        }

        //Also currently unutilized but this method prints out the books by their checked out property
        public void SearchLibraryCatalogByCheckedOut(bool checkout)
        {
            foreach (Book book in libraryCatalog)
            {
                if (book.GetCheckedOut() == checkout)
                {
                    string onShelf;

                    if (book.GetCheckedOut())
                    {
                        onShelf = "Checked Out";
                    }
                    else
                    {
                        onShelf = "On Shelf";
                    }

                    Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), onShelf, book.GetDueDate());
                }
            }
            Console.WriteLine(longLine);
        }

        //This method ensures that the user input for book selection exists on the catalog file, also accounting for null or whitespace
        public int GetUserBookIdSelect(string userBookIdSelect)
        {
            if (!string.IsNullOrWhiteSpace(userBookIdSelect))
            {
                if (int.TryParse(userBookIdSelect, out var userBookIdNum))
                {
                    if (userBookIdNum > 0 && userBookIdNum <= libraryCatalog.Count)
                    {
                        return userBookIdNum;
                    }
                }
            }
            return 0;
        }



        //Unutilized AddBook Method


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