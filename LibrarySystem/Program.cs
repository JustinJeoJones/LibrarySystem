using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var libraryCatalog = new Catalog();
            var lionWitchWadrobe = new Book("The Lion, the Witch, and the Wardrobe", "C.S. Lewis", 1, false);
            libraryCatalog.libraryCatalog.Add(lionWitchWadrobe);
            App.ShowMenu();
            var selection = App.GetMenuSelection();
            if (selection == 1)
            {
                App.PrintTable();
                libraryCatalog.ListBooksInLibraryCatalog();
            }

            
            Console.ReadLine();
        }
    }
}
