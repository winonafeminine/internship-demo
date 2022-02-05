using internship_api.Models;
using Microsoft.EntityFrameworkCore;
using internship_api.Models.user;
// using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// for the details please refer to this
// https://github.com/CuriousDrive/EFCore.AllDatabasesConsidered/tree/main/MySQL/Northwind.MySQL
// need to install dotnet ef locally
// if develop in remote container
builder.Services.AddDbContextPool<IntDbContext>(options => {
    options.UseMySql(
        builder.Configuration.GetConnectionString("InternConStr"),
        Microsoft.EntityFrameworkCore.ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("InternConStr"))
        );
});


// register all the dependency injections
builder.Services.AddScoped<IUser, UserImp>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
