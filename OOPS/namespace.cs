using System;
using Library;
using Person; 

namespace Library
{
    public class Books
    {
        public string Name;
        public string Author;
        public int Price;

        public Books(string name, int price, string author)
        {
            Name = name;
            Author = author;
            Price = price;
            Console.WriteLine("Book inserted successfully");
            Console.WriteLine();
        }

        public void BookInfo()
        {
            Console.WriteLine("Book Info");
            Console.WriteLine($"{Name} by {Author}, Price: {Price}");
            Console.WriteLine();
        }
    }

    public class Admin
    {
        private string name;

        public Admin(string name)
        {
            this.name = name;
        }

        public void BookCheckout(Books bk)
        {
            Console.WriteLine("Admin present: "+name);
            Console.WriteLine($"Checkout successful: {bk.Name} book Enjoy learning!");
            Console.WriteLine();
        }

        public void BookReturn(Books bk)
        {
            Console.WriteLine("Admin present: "+name);
            Console.WriteLine($"Return successful: {bk.Name} book Visit again!");
            Console.WriteLine();
        }
    }
}

namespace Person
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void TakeBook(Library.Books bk)
        {
            Console.WriteLine("Welcome " + name);
            Library.Admin admin = new Library.Admin("alice");
            admin.BookCheckout(bk);
        }

        public void ReturnBook(Library.Books bk)
        {
            Console.WriteLine("Welcome " + name);
            Library.Admin admin = new Library.Admin("Alice");
            admin.BookReturn(bk);
        }
    }
}

public class UsingTheNamespace
{
    public static void Main()
    {
        Library.Books b1 = new Library.Books("C#", 550, "Alex");
        b1.BookInfo();
        
        Person.Student s1 = new Person.Student("John");
        s1.TakeBook(b1);
        s1.ReturnBook(b1);
    }
}