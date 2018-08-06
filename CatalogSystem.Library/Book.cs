using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CatalogSystem.Library
{
    public class Book
    {
        //Object Properties
        private string _title { get; set; }
        private string _author { get; set; }
        private int _bookId { get; set; }
        private bool _checkedOut { get; set; }
        private DateTime? _dueDate { get; set; }

        //First Constructor method that doesn't take a dateTime for the dueDate setting it to null
        public Book(string title, string author, int bookId, bool checkedOut)
        {
            _title = title;
            _author = author;
            _bookId = bookId;
            _checkedOut = checkedOut;
            _dueDate = null;
        }

        //Second Constructor method that sets the dueDate of the book to the timestamp in the file
        public Book(string title, string author, int bookId, bool checkedOut, DateTime? dueDate)
        {
            _title = title;
            _author = author;
            _bookId = bookId;
            _checkedOut = checkedOut;
            _dueDate = dueDate;
        }

        //Get Methods that return the values as public entities
        public string GetTitle()
        {
            return _title;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public int GetBookId()
        {
            return _bookId;
        }
        public bool GetCheckedOut()
        {
            return _checkedOut;
        }
        public string GetDueDate()
        {
            return _dueDate.ToString();
        }

        //Set method to declare the duedate of the book if one exists on instantiation
        public void SetDueDate()
        {
            _dueDate = DateTime.Now.AddDays(14);
        }

        //Method to set the due date and set the book to checked out
        public void CheckOut(int bookId)
        {
            if (bookId == _bookId)
            {
                SetDueDate();
                _checkedOut = true;
            }       
        }

        //Method to remove due date once the checkedout status is set to false.
        public void CheckIn(int bookId)
        {
            if (bookId == _bookId)
            {
                _dueDate = null;
                _checkedOut = false;
            }
        }
        
    }
}
