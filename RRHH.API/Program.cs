using Microsoft.EntityFrameworkCore;
using RRHH.API.Database;
using RRHH.API.Services.Employees;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddDbContext<RRHHDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("EmployeesConnection"))
);

builder.Services.AddTransient<IEmployeeService, EmployeeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();