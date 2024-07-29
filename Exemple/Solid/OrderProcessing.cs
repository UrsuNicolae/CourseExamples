namespace Exemple.Solid
{

    // Clasă monolitică care încalcă principiile SOLID
    interface IOrderValidator
    {
        void ValidateOrder(Order order);
    }

    class OrderValidator : IOrderValidator
    {
        public void ValidateOrder(Order order)
        {
            if (order.OrderAmount <= 0)
            {
                throw new InvalidOperationException("Order amount must be greater than zero.");
            }
            Console.WriteLine("Order is valid.");
        }
    }

    interface IPaymentProcessor
    {
        void ProcessPayment(Order order);
    }

    class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            // Cod pentru procesarea plății
            Console.WriteLine($"Processing payment for Order ID: {order.OrderId}");

            // Cod specific pentru procesarea plății prin PayPal
            Console.WriteLine("Payment processed using PayPal.");
        }
    }

    interface IInvoiceGenerator
    {
        void GenerateInvoice(Order order);
    }

    class InvoiceGenerator : IInvoiceGenerator
    {
        public void GenerateInvoice(Order order)
        {
            // Cod pentru generarea facturii
            Console.WriteLine($"Generating invoice for Order ID: {order.OrderId}");
        }
    }

    interface INotificationService
    {
        void NotifyCustomer(Order order);
    }

    class NotificationService : INotificationService
    {
        public void NotifyCustomer(Order order)
        {
            // Cod pentru trimiterea emailului de notificare
            Console.WriteLine($"Sending email to {order.CustomerName}");
        }
    }


    class Order
    {
        // Proprietăți pentru gestionarea comenzii
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double OrderAmount { get; set; }
    }

    class OrderProcessing
    {
        private readonly IOrderValidator _orderValidator;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IInvoiceGenerator _invoiceGenerator;
        private readonly INotificationService _notificationService;

        public OrderProcessing()
        {
            _orderValidator = new OrderValidator();
            _paymentProcessor = new PaymentProcessor();
            _invoiceGenerator = new InvoiceGenerator();
            _notificationService = new NotificationService();
        }

        public OrderProcessing(IOrderValidator orderValidator,
            IPaymentProcessor paymentProcessor,
            IInvoiceGenerator invoiceGenerator,
            INotificationService notificationService)
        {
            _orderValidator = orderValidator;
            _paymentProcessor = paymentProcessor;
            _invoiceGenerator = invoiceGenerator;
            _notificationService = notificationService;
        }

        public void ProcessOrder(Order order)
        {
            _orderValidator.ValidateOrder(order);
            _paymentProcessor.ProcessPayment(order);
            _invoiceGenerator.GenerateInvoice(order);
            _notificationService.NotifyCustomer(order);
        }
    }

}
