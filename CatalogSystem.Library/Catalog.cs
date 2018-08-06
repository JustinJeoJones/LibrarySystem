using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogSystem.Library
{
    public class Catalog
    {
        public static string FormatOutput = "{0, -15} {1, -40} {2, -20} {3, -20} {4, -20}";
        public Catalog()
        {
            libraryCatalog = new List<Book>();
        }

        public List<Book> libraryCatalog { get; set; }
        public static string longLine = "==========================================================================================================================";


        public void ListBooksInLibraryCatalog()
        {
            
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
                
                Console.WriteLine(FormatOutput, book.GetBookId(), book.GetTitle(), book.GetAuthor(), onShelf, book.GetDueDate());
            }
            Console.WriteLine(longLine);
        }

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
        
        public int GetUserBookIdSelect(string userBookIdSelect)
        {
            if (!string.IsNullOrWhiteSpace(userBookIdSelect))
            {
                int userBookIdNum;
                bool num1 = int.TryParse(userBookIdSelect, out userBookIdNum);
                if (userBookIdNum > 0 && userBookIdNum <= libraryCatalog.Count)
                {
                    //make CSV please!
                    return userBookIdNum;
                }
            }
            return 0;
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