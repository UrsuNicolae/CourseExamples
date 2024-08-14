using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class TestScopedDependency //: ITestScopedDependency
    {
        private readonly IWeatherForecastRepository repository;

        public TestScopedDependency(IWeatherForecastRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<WeatherForecast> GetAll()
        {
            return repository.GetAll();
        }
    }
}
