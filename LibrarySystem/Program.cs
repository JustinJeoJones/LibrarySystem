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
            App.ShowMenu();
            var selection = App.GetMenuSelection();
            if (selection == 1)
            {
                App.PrintTable();
                libraryCatalog.ListBooksInLibraryCatalog();
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
