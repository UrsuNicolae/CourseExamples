using WebApplication1.Middlewares;
using WebApplication1.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped</*ITestScopedDependency, */TestScopedDependency>();
builder.Services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

/*app.UseAuthentication();//allways first
app.UseAuthorization();//allways second*/

/*app.UseExceptionHandler();*/
app.UseMiddleware<RequestLoggingMiddleware>();
app.MapControllers();


app.Run();
