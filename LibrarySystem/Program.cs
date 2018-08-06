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

                if (selection == 2)
                {
                    var query = App.GetSearchQuery();
                    App.PrintTable();
                    libraryCatalog.SearchLibraryCatalogByAuthor(query);
                }

                if (selection == 3)
                {
                    var query = App.GetSearchQuery();
                    App.PrintTable();
                    libraryCatalog.SearchLibraryCatalogByKeyword(query);
                }

                if (selection == 4)
                {
                    bool actionComplete = false;
                    do
                    {
                       Console.WriteLine("Would you like to Checkout or Return a Book: (checkout/return)");
                        var action = Console.ReadLine().ToLower();
                        switch (action)
                        {
                            case "checkout":
                            {
                                libraryCatalog.ListBooksInLibraryCatalog();

                                int userBookIdNum;
                                do
                                {
                                    Console.WriteLine("Select the serial ID of the book you want to Checkout");
                                    userBookIdNum = libraryCatalog.GetUserBookIdSelect(Console.ReadLine());
                                } while (!Validator.IsValidId(libraryCatalog.libraryCatalog, userBookIdNum));

                                libraryCatalog.libraryCatalog[userBookIdNum - 1].CheckOut(userBookIdNum);

                            }
                                actionComplete = true;
                                break;
                            case "return":
                            {
                                libraryCatalog.ListBooksInLibraryCatalog();

                                int userBookIdNum;
                                do
                                {
                                    Console.WriteLine("Select the serial ID of the book you want to Return");
                                    userBookIdNum = libraryCatalog.GetUserBookIdSelect(Console.ReadLine());
                                } while (!Validator.IsValidId(libraryCatalog.libraryCatalog, userBookIdNum));

                                libraryCatalog.libraryCatalog[userBookIdNum - 1].CheckIn(userBookIdNum);

                            }
                                actionComplete = true;
                                break;
                        }
                    } while (!actionComplete);


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
