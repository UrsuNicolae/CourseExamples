namespace Template2
{
    public class OrderProcessingTests
    {
        [Fact]
        public void ProcessOrder_WhenOrderIsValid_ProcessesOrder()
        {
            // Arrange
            var order = new Order { OrderId = 1, OrderAmount = 10 };
            var orderValidator = new Mock<IOrderValidator>();
            orderValidator.Setup(x => x.ValidateOrder(order));

            var paymentProcessor = new Mock<IPaymentProcessor>();
            paymentProcessor.Setup(x => x.ProcessPayment(order));

            var invoiceGenerator = new Mock<IInvoiceGenerator>();
            invoiceGenerator.Setup(x => x.GenerateInvoice(order));

            var notificationService = new Mock<INotificationService>();
            notificationService.Setup(x => x.NotifyCustomer(order));

            var orderProcessing = new OrderProcessing(orderValidator.Object,
                paymentProcessor.Object,
                invoiceGenerator.Object,
                notificationService.Object);

            // Act
            orderProcessing.ProcessOrder(order);

            // Assert
            orderValidator.Verify(x => x.ValidateOrder(order), Times.Once);
            paymentProcessor.Verify(x => x.ProcessPayment(order), Times.Once);
            invoiceGenerator.Verify(x => x.GenerateInvoice(order), Times.Once);
            notificationService.Verify(x => x.NotifyCustomer(order), Times.Once);
        }
    }
}
