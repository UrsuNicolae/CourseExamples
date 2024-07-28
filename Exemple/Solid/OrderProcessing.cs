namespace Exemple.Solid
{
    using System;

    // Clasă monolitică care încalcă principiile SOLID
    class OrderProcessing
    {
        // Proprietăți pentru gestionarea comenzii
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double OrderAmount { get; set; }

        // Metodă pentru procesarea plății
        public void ProcessPayment()
        {
            // Cod pentru procesarea plății
            Console.WriteLine($"Processing payment for Order ID: {OrderId}");

            // Cod specific pentru procesarea plății prin PayPal
            Console.WriteLine("Payment processed using PayPal.");
        }

        // Metodă pentru generarea facturii
        public void GenerateInvoice()
        {
            // Cod pentru generarea facturii
            Console.WriteLine($"Generating invoice for Order ID: {OrderId}");
        }

        // Metodă pentru notificarea clientului
        public void NotifyCustomer()
        {
            // Cod pentru trimiterea emailului de notificare
            Console.WriteLine($"Sending email to {CustomerName}");
        }

        // Metodă pentru validarea comenzii
        public void ValidateOrder()
        {
            // Cod pentru validarea comenzii
            if (OrderAmount <= 0)
            {
                throw new InvalidOperationException("Order amount must be greater than zero.");
            }
        }
    }

    class OrderProcessingProgram
    {
        static void Main(string[] args)
        {
            // Crearea și procesarea unei comenzi
            OrderProcessing order = new OrderProcessing
            {
                OrderId = 1,
                CustomerName = "John Doe",
                OrderAmount = 100.0
            };

            order.ValidateOrder();
            order.ProcessPayment();
            order.GenerateInvoice();
            order.NotifyCustomer();
        }
    }

}
