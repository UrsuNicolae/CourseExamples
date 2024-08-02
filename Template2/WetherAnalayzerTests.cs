namespace Template2
{
    public class WetherAnalayzerTests
    {
        [Fact]
        public void AnalyzeWeatherShouldReturnColdWhenTemperatureIsLessThan10()
        {
            // Arrange
            var weatherService = new Mock<IWeatherService>();
            weatherService.Setup(x => x.GetTemperature("New York")).Returns(5);
            var weatherAnalyzer = new WeatherAnalyzer(weatherService.Object);

            // Act
            var weather = weatherAnalyzer.AnalyzeWeather("New York");

            // Assert
            Assert.Equal("Cold", weather);
        }

        [Fact]
        public void AnalyzeWeatherShouldReturnModerateWhenTemperatureIsLessThan25()
        {
            // Arrange
            var weatherService = new Mock<IWeatherService>();
            weatherService.Setup(x => x.GetTemperature("Chisinau")).Returns(15);
            var weatherAnalyzer = new WeatherAnalyzer(weatherService.Object);

            // Act
            var weather = weatherAnalyzer.AnalyzeWeather("Chisinau");

            // Assert
            Assert.Equal("Moderate", weather);
        }

        [Fact]
        public void AnalyzeWeatherShouldReturnHotWhenTemperatureIsGreaterThan25()
        {
            // Arrange
            var weatherService = new Mock<IWeatherService>();
            weatherService.Setup(x => x.GetTemperature("Bucuresti")).Returns(30);
            var weatherAnalyzer = new WeatherAnalyzer(weatherService.Object);

            // Act
            var weather = weatherAnalyzer.AnalyzeWeather("Bucuresti");

            // Assert
            Assert.Equal("Hot", weather);
        }

        [Fact]
        public void AnalyzeWeatherShouldInvokeAtLeastOnceGetTemperature()
        {
            // Arrange
            var weatherService = new Mock<IWeatherService>();
            var weatherAnalyzer = new WeatherAnalyzer(weatherService.Object);

            // Act
            var weather = weatherAnalyzer.AnalyzeWeather("Bucuresti");

            // Assert
            weatherService.Verify(x => x.GetTemperature("Bucuresti"), Times.Exactly(1));
            weatherService.Verify(x => x.GetTemperature("Chisinau"), Times.Never);
        }
    }
}
