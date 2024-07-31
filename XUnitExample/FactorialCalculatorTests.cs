using Exemple.UTs;
using Xunit;

namespace XUnitExample
{
    public class FactorialCalculatorTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(5, 120)]
        [InlineData(10, 3628800)]
        public void TestCalculateFactorial(int n, int expectedFactorial)
        {
            // Arrange
            FactorialCalculator1 calculator = new FactorialCalculator1();


            // Act
            int result = calculator.CalculateFactorial(n);


            // Assert
            Assert.Equal(expectedFactorial, result);
        }

    }
}