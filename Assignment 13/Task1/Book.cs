using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Book
    {
        private int _bookNumber { get; set; }
        private string _title { get; set; }
        private string _author { get; set; }

        public Book(int bookNumber, string title, string author) 
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title cannot be empty.");
            }

            if (string.IsNullOrEmpty(author))
            {
                throw new ArgumentNullException("Author cannot be empty.");
            }

            this._bookNumber = bookNumber;
            this._title = title;
            this._author = author;
        }

        public int BookNumber { get { return _bookNumber; } set { _bookNumber = value; } } 
        public string Title { get { return _title; } set { _title = value; } }
        public string Author { get { return _author; } set { _author = value; } }
    }
}
