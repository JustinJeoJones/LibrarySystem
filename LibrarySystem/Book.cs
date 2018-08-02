using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Book
    {
        //declarations for ctor
        private string _title { get; set; }
        private string _author { get; set; }
        private int _bookId { get; set; }
        private bool _checkedOut { get; set; }
        private DateTime? _dueDate { get; set; }

        //ctor for book
        private Book(string title, string author, int bookId, bool checkedOut)
        {
            _title = title;
            _author = author;
            _bookId = bookId;
            _checkedOut = checkedOut;
            _dueDate = null;
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
        public int GetbookId()
        {
            return _bookId;
        }
        public bool GetcheckedOut()
        {
            return _checkedOut;
        }
        public void SetDueDate()
        {
            _dueDate = DateTime.Now.AddDays(14);
        }

        //Check Out
        public void checkOut(bool _checkedOut)
        {
            SetDueDate();
            _checkedOut = true;            
        }

        //Check In
        public void checkIn(bool _checkedOut)
        {
            DateTime? _dueDate = null;
            _checkedOut = false;
        }
        //Refactor Checked out status based on the DueDate value
    }
}
