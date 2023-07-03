using System;
using Task1;

Book book1 = new Book(1, "Treasure Island", "Robert Louis Stevenson");
Book book2 = new Book(2, "The Three Musketeers", "Alexandre Dumas");
Book book3 = new Book(3, "The Jungle Book", "Rudyard Kipling");
Book book4 = new Book(4, "Adventures of Huckleberry Finn", "Mark Twain");

try
{
    Book book = new Book(0, "", "");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Program execution completed");
}

Library library = new Library();

library.LibraryCapacity = 3;

//library.AddBook(book);

/* Add Book */
try
{
    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3);
    Console.WriteLine("Add Successfully!");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Program execution completed");
}

/* Add Book Exception */
try
{
    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3);
    library.AddBook(book4);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Program execution completed");
}

/* Get Book */
try
{
    Book book = library.GetBook(2);
    Console.WriteLine($"Found book: {book.Title} by {book.Author}");
}
catch (BookNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Program execution completed");
}

/* Get Book Exception */
try
{
    Book book = library.GetBook(4);
    Console.WriteLine($"Found book: {book.Title} by {book.Author}");
}
catch (BookNotFoundException ex)
{
    Console.WriteLine(ex.Message + " - " + ex.ExceptionDate);
}
finally
{
    Console.WriteLine("Program execution completed");
}