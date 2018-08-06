using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace CatalogSystem.Library
{
    public sealed class Stream
    {
        //Instantiate a new stream as Instance name
        private static Stream Instance = new Stream();
        
        //Declare file path for reference
        public static string path = $"{Directory.GetCurrentDirectory()}\\catalog.csv";

        //Check whether or not the file exists in the given path
        public static bool FileExists()
        {
            return File.Exists(path);
        }

        //Return the instance of the Stream
        public static Stream GetInstance()
        {
            return Instance;
        }

        //Method that takes the catalog.csv file and parses it out into book objects based on the number of rows in the file
        public static void ReadCatalogFile(Catalog libraryCatalog, ref int counter)
        {
            //Check if the file exists
            if (FileExists())
            {
                //Instantiate a new TextFieldParser that will handle all csv parsing
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    //establish the delimeter of comma so it will splice values at commas
                    csvParser.SetDelimiters(new string[] {","});
                    //Enable fields closed in quotes which allows for commas within double quotes on title fields not parsing on them.
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    //While the file still has rows continue to loop through them
                    while (!csvParser.EndOfData)
                    {
                        //set temporary book object book
                        Book book;
                        DateTime? dueDate;

                        // Read current line fields, pointer moves to the next line.
                        string[] fields = csvParser.ReadFields();
                        string title = fields[1];
                        string author = fields[2];

                        //try catch for whether or not the row contains a parsable dateTime.
                        //If not it sets the dateTime to null
                        try
                        {
                            dueDate = DateTime.Parse(fields[4]);
                        }
                        catch (FormatException)
                        {
                            dueDate = null;
                        }

                        //checks whether or not the book is checked out
                        //and sets it to lower so that the bool parse can set the value
                        bool checkedOut = bool.Parse(fields[3].ToLower());

                        //Increment the counter to ensure the Id is set to the proper value
                        counter++;

                        //If there is a duedate on the row, call the Second constructor on the
                        //book object that sets the dueDate.
                        if (dueDate != null)
                        {
                            book = new Book(title, author, counter, checkedOut, dueDate);
                        }
                        //If there is no dueDate utilize the First book constructor
                        else
                        {
                            book = new Book(title, author, counter, checkedOut);
                        }

                        //Add the new book to the libraryCatalog List of books
                        libraryCatalog.libraryCatalog.Add(book);
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        //Method that takes the current working version of the libraryCatalog list of books and writes it to the catalog.csv file
        public static void WriteCatalogToFile(Catalog libraryCatalog)
        {
            //check if file exists
            if (FileExists())
            {
                //Instantiate a new StreamWriter as writer with the given path
                using (StreamWriter writer = new StreamWriter(path))
                {
                    //Iterate through each book in the libraryCatalog list
                    foreach (var book in libraryCatalog.libraryCatalog)
                    {
                        //get the properties of each book as temporary values
                        var bookId = book.GetBookId();
                        var title = book.GetTitle();
                        var author = book.GetAuthor();
                        var checkedOut = book.GetCheckedOut();
                        var dueDate = book.GetDueDate();

                        //using the temporary values set a new row in the file overwriting the existing data
                        writer.WriteLine($"{bookId},\"{title}\",{author},{checkedOut},{dueDate}");

                        //Drop all temporary data remaining so there are no conflicts with the next book instance
                        writer.Flush();

                    }
                }
            }
        }
    }
}