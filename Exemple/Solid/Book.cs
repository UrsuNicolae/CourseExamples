using System.Diagnostics;

namespace Exemple.Solid
{
    public class Stand
    {
        public void Display(Book book)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price:C}, ISBN: {book.ISBN}");
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscountedPrice(Book book, decimal discountPercentage)
        {
            return book.Price - (book.Price * discountPercentage / 100);
        }
    }

    public class  BookRepository
    {
        public void Save(Book book)
        {
            // Salvează datele cărții în baza de date
            Console.WriteLine($"Saving book ${book.Title} data to database...");
        }

        public void Load(string isbn)
        {
            // Încarcă datele cărții din baza de date
            Console.WriteLine("Loading book data from database...");
        }
    }


    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
    }

}
