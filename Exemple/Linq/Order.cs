namespace Exemple.Linq
{
    internal class Order
    {
        public int OrderId { get; set; }

        public string Product { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }



    /*
     var orders = new[]
                {
                    new Order { OrderId = 1, Product = "Book", Quantity = 10, Price = 100 },
                    new Order { OrderId = 2, Product = "Game", Quantity = 5, Price = 250 },
                    new Order { OrderId = 3, Product = "Phone", Quantity = 1, Price = 800 },
                    new Order { OrderId = 4, Product = "Book", Quantity = 5, Price = 50 },
                    new Order { OrderId = 5, Product = "Phone", Quantity = 2, Price = 160 },
                    new Order { OrderId = 6, Product = "Game", Quantity = 3, Price = 150 },
                    new Order { OrderId = 7, Product = "Book", Quantity = 2, Price = 20 },
                    new Order { OrderId = 8, Product = "Game", Quantity = 1, Price = 50 }
                };

                var groupedOrders = orders.GroupBy(order => order.Product);

                var groupDetails = groupedOrders.Select(group => new
                {
                    Product = group.Key,
                    TotalQuantity = group.Sum(order => order.Quantity),
                    TotalPrice = group.Sum(order => order.Price)
                });

                foreach (var groupDetail in groupDetails)
                {
                    Console.WriteLine($"Product: {groupDetail.Product}, Total Quantity: {groupDetail.TotalQuantity}, Total Price: {groupDetail.TotalPrice}");
                }*/
}
