namespace Template2
{
    public class CustomerServiceTests
    {
        [Fact]
        public void CustomerServiceShouldReturnCustomerNameWhenFound()
        {

            // Arrange
            var customerRepository = new Mock<ICustomerRepository>();
            customerRepository.Setup(x => x.GetCustomerById(1)).Returns(new Customer { Name = "John Doe" });
            var customerService = new CustomerService(customerRepository.Object);

            // Act
            var customerName = customerService.GetCustomerName(1);

            // Assert
            Assert.Equal("John Doe", customerName);
        }

        [Fact]
        public void CustomerServiceShouldReturnUnknownWhenNotFound()
        {

            // Arrange
            var customerRepository = new Mock<ICustomerRepository>();
            customerRepository.Setup(x => x.GetCustomerById(It.IsAny<int>())).Returns(new Customer());
            var customerService = new CustomerService(customerRepository.Object);

            // Act
            var customerName = customerService.GetCustomerName(1);

            // Assert
            Assert.Equal("Unknown", customerName);
        }

        [Fact]
        public void CustomerServiceShouldCallGetCustomerExactlyOnece()
        {

            // Arrange
            var customerRepository = new Mock<ICustomerRepository>();
            //customerRepository.Setup(x => x.GetCustomerById(It.IsAny<int>())).Returns(new Customer());
            var customerService = new CustomerService(customerRepository.Object);

            // Act
            var customerName = customerService.GetCustomerName(1);

            // Assert
            customerRepository.Verify(x => x.GetCustomerById(1), Times.Once);
        }
    }
}
