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

    interface IDiscountCalculator
    {
        decimal CalculateDiscount(Product product);
    }


    // Clasa pentru calcularea reducerilor
    class DiscountCalculator : IDiscountCalculator
    {
        public virtual decimal CalculateDiscount(Product product)
        {
            // Logica pentru calcularea reducerii
            return product.Price * 0.1M; // Reducere de 10%
        }
    }

    class HolidayDiscauntCalculator : DiscountCalculator
    {
        public override decimal CalculateDiscount(Product product)
        {
            return product.Price * 0.2M; // Reducere de 20%
        }
    }

    class WeekDiscountCalculator : DiscountCalculator
    {
        public override decimal CalculateDiscount(Product product)
        {
            return product.Price * 0.15M; // Reducere de 15%
        }
    }


    /*class Test
    {
        public decimal CalcualatePrice(Order order, DiscountCalculator discountCalculator)
        {
            return order.Product.Price - discountCalculator.CalculateDiscount(order.Product);
        }
    }*/


    // Clasa pentru gestionarea comenzilor
    class ProductOrder
    {
        public Product Product { get; set; }
        public decimal TotalPrice { get; set; }


        public void CalculateTotalPrice(IDiscountCalculator discountCalculator)
        {
            TotalPrice = Product.Price - discountCalculator.CalculateDiscount(null);
        }
    }


    /*class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product { Name = "Laptop", Price = 1000 };
            var discountCalculator = new HolidayDiscauntCalculator();
            Order order = new Order { Product = product };
            order.CalculateTotalPrice(discountCalculator);

            Console.WriteLine($"Total price after discount: ${order.TotalPrice}");
        }
    }*/

}
