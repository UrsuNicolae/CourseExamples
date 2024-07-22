using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Solid
{
    using System;


    // Clasa de bază pentru produse
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }


    // Clasa pentru calcularea reducerilor
    class DiscountCalculator
    {
        public decimal CalculateDiscount(Product product)
        {
            // Logica pentru calcularea reducerii
            return product.Price * 0.1M; // Reducere de 10%
        }
    }


    // Clasa pentru gestionarea comenzilor
    class Order
    {
        public Product Product { get; set; }
        public decimal TotalPrice { get; set; }


        public void CalculateTotalPrice(DiscountCalculator discountCalculator)
        {
            TotalPrice = Product.Price - discountCalculator.CalculateDiscount(Product);
        }
    }


    /*class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product { Name = "Laptop", Price = 1000 };
            DiscountCalculator discountCalculator = new DiscountCalculator();
            Order order = new Order { Product = product };

            order.CalculateTotalPrice(discountCalculator);

            Console.WriteLine($"Total price after discount: ${order.TotalPrice}");
        }
    }*/

}
