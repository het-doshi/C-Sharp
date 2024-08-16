using System;

public class Book
{
    public string Title;
    public int Price;

    // Constructor for a single Book object
    public Book(string title, int price)
    {
        Title = title;
        Price = price;
    }

    // Array of Book objects
    private Book[] books;

    // Constructor to initialize the collection of books
    public Book(Book[] books)
    {
        this.books = books;
    }

    // Indexer for accessing Book objects
    public Book this[int index]
    {
        get
        {
            if (index < 0 || index >= books.Length)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            return books[index];
        }
        set
        {
            if (index < 0 || index >= books.Length)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            books[index] = value;
        }
    }

    public static void Main()
    {
        // Creating an array of Book objects
        Book[] booksArray = new Book[]
        {
            new Book("Book1", 30),
            new Book("Book2", 25),
            new Book("Book3", 35)
        };

        // Creating a collection of books
        Book bookCollection = new Book(booksArray);

        // Accessing Book objects using the indexer
        Console.WriteLine("Title: " + bookCollection[0].Title);
        Console.WriteLine("Price: " + bookCollection[0].Price);
    }
}