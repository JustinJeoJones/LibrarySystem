using System;
using System.ComponentModel.Design;

namespace LibrarySystem
{
    public class App
    {
        public static void ShowMenu() =>
            Console.WriteLine(
                $"\n\t1-List catalog.\n\t2-Search by author\n\t3-Search by Title Keyword\n\t4-Checkout/Return a Book\n\t5-Quit\n");
        public static string formatOutput = "{0, -15} {1, -40} {2, -20} {3, -20} {4, -20}";
        public static string shortLine = "==============================================";
        public static string longLine = "==========================================================================================================================";
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

        public static void PrintTable()
        {
            Console.WriteLine(longLine);
            Console.WriteLine(formatOutput, " SerialNo.", "Title", "Author", "Checked Out", "Due Date");
            Console.WriteLine(longLine);
            
        }

        private static bool ContinueProgram()
        {
            do
            {
                Console.WriteLine("Continue y/n");
                var input = Console.ReadLine().ToLower();

                if (input != "y" && input != "n")
                {
                    continue;
                }

                return input == "y";
            } while (true);
        }

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

    }
}