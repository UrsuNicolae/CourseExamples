﻿using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface ITestScopedDependency
    {
        IEnumerable<WeatherForecast> GetAll();
    }
}
