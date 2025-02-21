using task3.Services.Abstract;
using task3.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

//app.MapGet("/", () => "Hello World!");

builder.Services.AddSingleton<ICalculationService, FibonachiService>();
// builder.Services.AddSingleton<ICalculationService, FactorialService>();
var app = builder.Build();
var service = app.Services.GetRequiredService<ICalculationService>();

app.MapGet("/fibonachi", (int index) =>
{
    try
    {
        int res = service.Calculate(index);
        return Results.Ok(res);
    }
    catch (ArgumentOutOfRangeException ex)
    {
        return Results.BadRequest(ex.Message);
    }
});

app.Run();
