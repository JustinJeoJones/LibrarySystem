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
            var libraryCatalog = new Catalog();
            var lionWitchWadrobe1 = new Book("The Lion, the Witch, and the ", "C.S. Lewis", 1, false);
            var lionWitchWadrobe2 = new Book("The Lion, the Witch, and ", "C.S. Lewis", 2, false);
            var lionWitchWadrobe3 = new Book("The Lion, the Witch", "C.S. Lewis", 3, false);
            var lionWitchWadrobe4 = new Book("The Lion, the ", "C.S. Lewis", 4, false);
            var lionWitchWadrobe5 = new Book("The Lion, ", "C.S. Lewis", 5, false);
            var lionWitchWadrobe6 = new Book("The Lion", "C.S. Lewis", 6, false);
            var lionWitchWadrobe7 = new Book("The ", "C.S. Lewis", 7, false);
            var lionWitchWadrobe8 = new Book("", "C.S. Lewis", 8, false);
            var lionWitchWadrobe9 = new Book("The Lion,", "C.S. Lewis", 9, false);
            var lionWitchWadrobe10 = new Book("The Lion, the Witch, ", "d.S. Lewis", 10, false);
            var lionWitchWadrobe11 = new Book("The Lion, the Witch, and the ", "C.S. Lewis", 11, false);
            var lionWitchWadrobe12 = new Book("The Lion, the Witch, and the Wardrobe", "C.S. Lewis1", 12, false);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe1);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe2);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe3);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe4);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe5);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe6);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe7);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe8);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe9);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe10);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe11);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe12);
            App.ShowMenu();
            var selection = App.GetMenuSelection();
            if (selection == 1)
            {
                App.PrintTable();
                libraryCatalog.ListBooksInLibraryCatalog();
            }

            Stream.StreamExists(libraryCatalog);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
