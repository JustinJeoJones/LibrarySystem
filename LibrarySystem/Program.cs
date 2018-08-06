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
            Console.WriteLine($"{App.shortLine}\n///////// Welcome to Library System! /////////\n{App.shortLine}");
            var libraryCatalog = new Catalog();
            int counter = libraryCatalog.libraryCatalog.Count;
            Stream.ReadCatalogFile(libraryCatalog, ref counter);

            App.MenuInputHandler(libraryCatalog);

            Console.WriteLine("Visit the Library Again!");

            Console.ReadLine();
        }
    }
}
