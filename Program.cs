using Microsoft.AspNetCore.HttpLogging;
using my_webapi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddHttpLogging(o =>
{
    o.LoggingFields = HttpLoggingFields.RequestMethod
                    | HttpLoggingFields.RequestPath
                    | HttpLoggingFields.RequestQuery
                    | HttpLoggingFields.ResponseStatusCode
                    | HttpLoggingFields.Duration;
});
builder.Services.AddControllers();
builder.Services.AddScoped<WeatherForecastService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpLogging();
app.MapControllers();

app.Run();
