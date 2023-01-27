using CustomerService.Application;
using CustomerService.Application.Customers;
using CustomerService.Domain.Abstractions;
using CustomerService.Presistence;
using CustomerService.Presistence.Repositories;
using CustomerService.WebApi;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddApplicationPart(AssemblyRefrences.Presentation);

builder.Services.AddMediatR(AssemblyRefrences.Application);

new ApplicationRegistrations().RegisterServices(builder);
new PresistenceRegistrations().RegisterServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
