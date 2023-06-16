
namespace LibrarySystem
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _year;
        private string _genre;
        private double _price;

        public string Title
        {
            get { 
                return _title; 
            }
            set { 
                _title = value; 
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }

    public class Library
    {
        private Book[] _books;

        public Book this[int index]
        {
            get
            {
                return _books[index];
            }
            set
            {
                _books[index] = value;
            }
        }

        public int LibraryCapacity
        {
            set
            {
                _books = new Book[value];
            }
        }

        public int Count
        {
            get
            {
                int count = 0;
                for(int i = 0; i < _books.Length; i++)
                {
                    if (_books[i] != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i] == null)
                {
                    _books[i] = book;
                    return;
                }
            }
        }

        public bool RemoveBook(Book book)
        {
            for(int i = 0; i < Count; i++)
            {
                if(_books[i] == book)
                {
                    _books[i] = null;
                    return true;
                }
            }
            return false;
        }

        public Book FindBook(string title)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_books[i].Title == title)
                {
                    return _books[i];
                }
            }
            Console.WriteLine("Ar moidzebna wigni!");
            return null;
        }
    }
}