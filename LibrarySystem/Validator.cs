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
                return number == book.GetBookId();

            }
        }
    }
}