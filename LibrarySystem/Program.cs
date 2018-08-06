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

            //Instantiate new Catalog class object
            var libraryCatalog = new Catalog();

            //Initialize the counter for the number of books in the library
            //so if we add books later they will increment properly and have unique ID
            int counter = libraryCatalog.libraryCatalog.Count;

            //Add books to the catalog based on the Stream class method of ReadCatalogFile
            Stream.ReadCatalogFile(libraryCatalog, ref counter);

            //Call the static method off the App class that allows the program
            //to get user input and select options based on that input
            App.MenuInputHandler(libraryCatalog);

            //Once the program has finished print out a simple message
            Console.WriteLine("Visit the Library Again!");

            Console.ReadKey();
        }
    }
}
