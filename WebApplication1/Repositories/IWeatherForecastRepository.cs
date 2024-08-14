using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> GetAll();
        WeatherForecast GetByName(string summary);
        void Create(WeatherForecast weather);
        void DeleteByName(string summary);

        void Update(WeatherForecast weather);
    }
}
