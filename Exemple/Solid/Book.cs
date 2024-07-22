using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Solid
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price:C}, ISBN: {ISBN}");
        }

        public decimal CalculateDiscountedPrice(decimal discountPercentage)
        {
            return Price - (Price * discountPercentage / 100);
        }

        public void Save()
        {
            // Salvează datele cărții în baza de date
            Console.WriteLine("Saving book data to database...");
        }

        public void Load(string isbn)
        {
            // Încarcă datele cărții din baza de date
            Console.WriteLine("Loading book data from database...");
        }
    }

}
