using LibrarySystem;

Book book1 = new Book()
{
    Title = "Treasure Island",
    Author = "Robert Louis Stevenson",
    Year = 1883,
    Genre = "Adventure",
    Price = 50
};

Book book2 = new Book()
{
    Title = "The Three Musketeers",
    Author = "Alexandre Dumas",
    Year = 1844,
    Genre = "Adventure",
    Price = 70
};

Book book3 = new Book()
{
    Title = "The Lord of the Rings",
    Author = "J.R.R. Tolkien",
    Year = 1954,
    Genre = "Fantasy",
    Price = 100
};

Library lib = new Library();

/* Arrays zomis gansazgvra */
lib.LibraryCapacity = 10;

/* library-is klasis wignebis masivshi Elementebis damateba */
lib.AddBook(book1);
lib.AddBook(book2);
lib.AddBook(book3);

/* Indexserit wignebis masivshi wignis amogeba */
var book = lib[1];
Console.WriteLine(
    $"Title - {book.Title}" + "\n" +
    $"Author - {book.Author}" + "\n" +
    $"Year - {book.Year}" + "\n" +
    $"Genre - {book.Genre}" + "\n" +
    $"Price - {book.Price}"
    );

/* Library klasshi arsebuli wignebis raodenoba */
var count = lib.Count;
Console.WriteLine($"Wignebis Raodenoba - {count} Wigni");

/* Library klasshi arsebuli wignebis masivshi wignis modzebna sataurit */
var findbook = lib.FindBook("");
if (findbook != null)
{
    Console.WriteLine(
    $"Title - {findbook.Title}" + "\n" +
    $"Author - {findbook.Author}" + "\n" +
    $"Year - {findbook.Year}" + "\n" +
    $"Genre - {findbook.Genre}" + "\n" +
    $"Price - {findbook.Price}"
    );
}

/* Library klasshi arsebuli wignebis masivshi edzebs 
 * chven gadacemu wigns da shlis masividan */
var removeBook = lib.RemoveBook(book1);
if(removeBook == true)
{
    Console.WriteLine("Wigni Waishala!");
}
else
{
    Console.WriteLine("Es Wigni Ar Aris Bibliotekashi!");
}