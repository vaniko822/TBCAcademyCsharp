using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task1
{
    public class Library
    {
        private List<Book> _books;
        private int _capacity;

        public Library()
        {
            _books = new List<Book>();
        }

        public int LibraryCapacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        public void AddBook(Book book)
        {
            if (book == null) 
            {
                throw new ArgumentNullException("Book can't be null!");
            }
            else if(_books.Count >= _capacity)
            {
                throw new IndexOutOfRangeException("The number of books in the library is overflowing");
            }

            _books.Add(book);
        }

        public Book GetBook(int bookNumber)
        {
            foreach(Book book in _books)
            {
                if(book.BookNumber == bookNumber)
                {
                    return book;
                }
            }

            throw new BookNotFoundException("Book not found in library", DateTime.Now);
        }
    }
}
