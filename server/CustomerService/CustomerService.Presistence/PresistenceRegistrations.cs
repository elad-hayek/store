using CustomerService.Domain.Abstractions;
using CustomerService.Presistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerService.Presistence;

public sealed class PresistenceRegistrations : IServiceRegistrator
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
        builder.Services.AddScoped<IUnitOfWork, IUnitOfWork>();

        builder.Services.AddDbContext<CustomerServiceDbContext>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString("UserServiceContext")));
    }
}
