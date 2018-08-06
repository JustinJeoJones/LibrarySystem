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
            int counter = libraryCatalog.libraryCatalog.Count;
            Stream.ReadCatalogFile(libraryCatalog, ref counter);

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
                    int userBookIdNum;
                    do
                    {
                        Console.WriteLine("Select the serial id of the book you want to checkout");
                        userBookIdNum = libraryCatalog.GetUserBookIdSelect(Console.ReadLine());
                    } while (!Validator.IsValidId(libraryCatalog.libraryCatalog, userBookIdNum));

                    libraryCatalog.libraryCatalog[userBookIdNum - 1].CheckOut(userBookIdNum);

                }

                if (selection == 5)
                {
                    Stream.WriteCatalogToFile(libraryCatalog);
                    break;
                }
            } while (true);

            Console.WriteLine("Visit the Library Again!");

            Console.ReadLine();
        }
    }
}
