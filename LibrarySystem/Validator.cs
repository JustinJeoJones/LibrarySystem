using System;
using CatalogSystem.Library;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class Validator
    {

        //Method to determine whether or not the number given exists as a valid Id within the Book List
        public static bool IsValidId(List<Book> libraryCatalog, int number)
        {
            foreach (Book book in libraryCatalog)
            {
                if (number == book.GetBookId())
                {
                    return true;
                }
            }

            //If the book isn't in the list inform the user
            Console.WriteLine("The book you're looking for doesn't exist");
            return false;
        }
    }
}