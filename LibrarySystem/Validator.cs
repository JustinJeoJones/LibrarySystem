using System;
using CatalogSystem.Library;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class Validator
    {

        public static bool IsValidId(List<Book> libraryCatalog, int number)
        {
            foreach (Book book in libraryCatalog)
            {
                if (number == book.GetBookId())
                {
                    return true;
                }
            }

            Console.WriteLine("The book you're looking for doesn't exist");

            return false;
        }
    }
}