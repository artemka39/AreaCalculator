using ShapeAreaCalculator;
using ShapeAreaCalculator.Backend.AreaCalculators;
using ShapeAreaCalculator.Common;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterRequiredServices();
var app = builder.Build();
app.UseCors(b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
