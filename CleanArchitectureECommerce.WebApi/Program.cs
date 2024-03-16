using CleanArchitectureECommerce.Infrastructure.Data;
using CleanArchitectureECommerce.Core.Interfaces;
using CleanArchitectureECommerce.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using CleanArchitectureECommerce.Application.Products.Queries;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(GetProductByIdQuery).Assembly);
builder.Services.AddTransient<IProductRepository, ProductRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
