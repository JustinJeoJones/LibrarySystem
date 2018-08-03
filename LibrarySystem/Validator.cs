using CatalogSystem.Library;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class Validator
    {
        //Test Data for future Validation

        //List<Book> Books = new List<Book>();

        //Books.Add(new Book("Moby Dick", "Herman Melville", 1, false));
        //Books.Add(new Book("War and Peace", "Leo Tolstoy", 2, false));
        //Books.Add(new Book("The Brothers Karamoazov", "Fyodor Dostoyevsky", 3, false));
        //Books.Add(new Book("The Lion, the Witch and the Wardrobe", "C.S.Lewis", 4, false));
        //Books.Add(new Book("Wuthering Heights", "Emily Brontë", 5, false));
        //Books.Add(new Book("The Children of Húrin", "J.R.R.Tolken", 6, false));
        //Books.Add(new Book("Go the F**k to Sleep", "Adam Mansbach", 7, false));
        //Books.Add(new Book("Les Misérables", "Victor Hugo", 8, false));
        //Books.Add(new Book("The Lorax", "Dr.Seuss", 9, false));
        //Books.Add(new Book("1984", "George Orwell", 10, false));
        //Books.Add(new Book("One Flew Over the Cuckoo’s Nest", "Ken Kesey", 11, false));
        //Books.Add(new Book("Slaughterhouse - Five", "Kurt Vonnegut", 12, false));

        public static bool IsValidId(List<Book> libraryCatalog, int number)
        {
            foreach (Book book in libraryCatalog)
            {
                if (number == book.GetBookId())
                {
                    return true;
                }
            }
            return false;
        }
    }
}