using System;
using System.ComponentModel.Design;
using System.Globalization;
using CatalogSystem.Library;

namespace LibrarySystem
{
    public class App
    {
        //Show menu method that lists options for user
        public static void ShowMenu() =>
            Console.WriteLine(
                $"\n\t1-List catalog.\n\t2-Search by author\n\t3-Search by Title Keyword\n\t4-Checkout/Return a Book\n\t5-Quit\n");

        //string formatting shorthands
        public static string formatOutput = "{0, -15} {1, -40} {2, -20} {3, -20} {4, -20}";
        public static string shortLine = "==============================================";
        public static string longLine = "==========================================================================================================================";

        //Method that gets the user input off of the main menu and case tests it against predetermined values
        //and returns the input as an integer if it matches one.
        public static int GetMenuSelection()
        {

            Console.Write("Enter menu number: ");
            var userInput = Console.ReadLine();
            try
            {
                var userInputAsInt = int.Parse(userInput);
                switch (userInputAsInt)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        return userInputAsInt;
                    default:
                        Console.WriteLine("The selection have made isn't on the menu list");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid Menu Selection");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }

            return GetMenuSelection();

        }


        //Print the headers for the tables on the catalog display.
        public static void PrintTable()
        {
            Console.WriteLine(longLine);
            Console.WriteLine(formatOutput, " SerialNo.", "Title", "Author", "Checked Out", "Due Date");
            Console.WriteLine(longLine);
            
        }

        //Get a search term from the user with which to pass into a catalog method using that term.
        //Ensure the term is not null or whitespace
        public static string GetSearchQuery()
        {
            string searchTerm;
            do
            {
                Console.WriteLine("Enter a search term: ");
                searchTerm = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    Console.WriteLine("please enter a valid search term");
                }
            } while (string.IsNullOrWhiteSpace(searchTerm));

            return searchTerm;
        }

        //Main method to handle the input from the user off of the main menu selections
        public static void MenuInputHandler(Catalog libraryCatalog)
        {
            //Loop for as long as the user doesn't select 5 "quit"
            do
            {
                //Show the menu options
                App.ShowMenu();
                //Get user selection
                var selection = App.GetMenuSelection();

                //case test user input against predetermined options
                switch (selection)
                {
                    //Print the entire catalog within the printed table
                    case 1:
                        App.PrintTable();
                        libraryCatalog.ListBooksInLibraryCatalog();
                        break;

                    //Get search term from user and search the author field with Title Case reference
                    case 2:
                    {
                        var query = App.GetSearchQuery();
                        App.PrintTable();
                        libraryCatalog.SearchLibraryCatalogByAuthor(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(query));
                        break;
                    }

                    //Get search term from user and search the title field for Contains keyword
                    case 3:
                    {
                        var query = App.GetSearchQuery();
                        App.PrintTable();
                        libraryCatalog.SearchLibraryCatalogByKeyword(query);
                        break;
                    }

                    //Split case wherein the user can either Checkout or Return a book
                    case 4:
                        bool actionComplete = false;

                        //get a user action and utilize switch statment to either return or checkout book
                        do
                        {
                            Console.WriteLine("Would you like to Checkout or Return a Book: (checkout/return)");
                            var action = Console.ReadLine().ToLower();
                            switch (action)
                            {
                                case "checkout":
                                {

                                    //Get the main catalog for comparison purposes and "List" the books
                                    libraryCatalog.ListBooksInLibraryCatalog();

                                    int userBookIdNum;
                                    //Do while that ensures the user selects a book within the catalog range
                                    do
                                    {
                                        Console.WriteLine("Select the serial ID of the book you want to Checkout");
                                        userBookIdNum = libraryCatalog.GetUserBookIdSelect(Console.ReadLine());
                                    } while (!Validator.IsValidId(libraryCatalog.libraryCatalog, userBookIdNum));

                                    //Once an input is validated set the book to CheckedOut using the checkout function
                                    libraryCatalog.libraryCatalog[userBookIdNum - 1].CheckOut(userBookIdNum);

                                }
                                    //break out of the do while
                                    actionComplete = true;
                                    break;

                                //case for return a book
                                case "return":
                                {
                                    //List all the books in the catalog
                                    libraryCatalog.ListBooksInLibraryCatalog();

                                    int userBookIdNum;
                                    
                                    //Validate user input to ensure the selection exists within the catalog range
                                    do
                                    {
                                        Console.WriteLine("Select the serial ID of the book you want to Return");
                                        userBookIdNum = libraryCatalog.GetUserBookIdSelect(Console.ReadLine());
                                    } while (!Validator.IsValidId(libraryCatalog.libraryCatalog, userBookIdNum));

                                    //Set checkedOut value of book to false and reset the dueDate to null
                                    libraryCatalog.libraryCatalog[userBookIdNum - 1].CheckIn(userBookIdNum);

                                }
                                    //Break out of the loop
                                    actionComplete = true;
                                    break;
                            }
                        } while (!actionComplete);

                        break;
                }

                //Write the current state of the libraryCatalog to the .csv file and then quit the program
                if (selection == 5)
                {
                    Stream.WriteCatalogToFile(libraryCatalog);
                    break;
                }
            } while (true);
        }
    }
}