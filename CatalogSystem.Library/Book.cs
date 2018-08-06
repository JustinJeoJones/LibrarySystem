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
        //declarations for ctor
        private string _title { get; set; }
        private string _author { get; set; }
        private int _bookId { get; set; }
        private bool _checkedOut { get; set; }
        private DateTime? _dueDate { get; set; }

        //ctor for book
        public Book(string title, string author, int bookId, bool checkedOut)
        {
            _title = title;
            _author = author;
            _bookId = bookId;
            _checkedOut = checkedOut;
            _dueDate = null;
        }
        public Book(string title, string author, int bookId, bool checkedOut, DateTime? dueDate)
        {
            _title = title;
            _author = author;
            _bookId = bookId;
            _checkedOut = checkedOut;
            _dueDate = dueDate;
        }



        //methods for grabbing categories
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
        public void SetDueDate()
        {
            _dueDate = DateTime.Now.AddDays(14);
        }

        //Check Out
        public void CheckOut(int bookId)
        {
            if (bookId == _bookId)
            {
                SetDueDate();
                _checkedOut = true;
            }
                        
        }

        //Check In
        public void CheckIn(int bookId)
        {
            if (bookId == _bookId)
            {
                DateTime? _dueDate = null;
                _checkedOut = false;
            }
        }
        //Refactor Checked out status based on the DueDate value
    }
}
