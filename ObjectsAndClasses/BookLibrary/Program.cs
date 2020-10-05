using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //To model a book library, define classes to hold a book and a library.
            //The library must have a name and a list of books.The books must contain the title, 
            //author, publisher, release date(in dd.MM.yyyy format), ISBN - number and price. 
            //Read a list of books, add them to the library and print the total sum of prices by author, 
            //ordered descending by price and then by author’s name lexicographically.
            //Books in the input will be in format {title}{author}{publisher}{release date}{ISBN}{price}.
            //The total prices must be printed formatted to the second decimal place.
            //Tolkien -> 40.25

            int numberOfBooks = int.Parse(Console.ReadLine());
            List<Book> myBooks = new List<Book>();

            for (int num = 0; num < numberOfBooks; num++)
            {
                List<string> inputLineL = Console.ReadLine().Split().ToList();
                Book book = new Book();
                book.Title = inputLineL[0];
                book.Author = inputLineL[1];
                book.Publisher = inputLineL[2];
                book.ReleaseDate = DateTime.ParseExact(inputLineL[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = inputLineL[4];
                book.Price = double.Parse(inputLineL[5]);

                myBooks.Add(book);
            }

            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var book in myLibrary.Books.GroupBy(x => x.Author).OrderByDescending(x => x.Sum(y => y.Price)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(x => x.Price):f2}");
            }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public double Price { get; set; }
        }

        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }
    }
}
