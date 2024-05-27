using CackeBack.DAL.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Cart.Application;
using Cart.Infrastructure;
using Shared.MediatRImplement;
using CackeBack.BLL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CartModule Extentions 
builder.Services.AddShoppingCartApplication(builder.Configuration);
builder.Services.AddShoppingCartInfrastructure(builder.Configuration);

// Mediatr configuration
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblyContaining<CartApplicationAssemblyReference>();
    // config.RegisterServicesFromAssemblyContaining<MediatRImplementAssemblyRegerence>();
});

// Mock 
builder.Services.AddScoped<MockService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
