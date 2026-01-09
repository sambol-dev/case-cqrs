using MediatR;
using CqrsSample.Application;
using CqrsSample.Application.Common;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// MediatR 11
builder.Services.AddMediatR(typeof(ApplicationAssemblyReference));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
