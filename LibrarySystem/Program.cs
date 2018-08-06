using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogSystem.Library;
using Stream = CatalogSystem.Library.Stream;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Library System!");
            var libraryCatalog = new Catalog();
            Stream.ReadCatalogFile(libraryCatalog);
            do
            {
                App.ShowMenu();
                var selection = App.GetMenuSelection();
                if (selection == 1)
                {
                    App.PrintTable();
                    libraryCatalog.ListBooksInLibraryCatalog();
                }

                if (selection == 4)
                {
                    libraryCatalog.ListBooksInLibraryCatalog();
                    //Add validation for this
                    Console.WriteLine("Select the serial id of the book you want to checkout");
                    var bookId = int.Parse(Console.ReadLine());
                    libraryCatalog.libraryCatalog[bookId - 1].checkOut(bookId);

                }

                if (selection == 5)
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Visit the Library Again!");

            Console.ReadLine();
        }
    }
}
