using CustomerService.Application.Customers;
using CustomerService.Domain.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerService.Application;

public sealed class ApplicationRegistrations : IServiceRegistrator
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<CustomerManager>();
    }
}
