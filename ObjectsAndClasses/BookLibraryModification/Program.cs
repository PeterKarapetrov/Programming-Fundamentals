using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the classes from the previous problem and make a program that read a list of books and 
            //print all titles released after given date ordered by date and then by title lexicographically.
            //The date is given in the format “dd.MM.yyyy” at the last line in the input.

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

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var book in myLibrary.Books.Where(x => x.ReleaseDate > date).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
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
