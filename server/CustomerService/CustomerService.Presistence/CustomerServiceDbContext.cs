using CustomerService.Domain.Abstractions;
using CustomerService.Presistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Presistence;

public sealed class CustomerServiceDbContext : DbContext, IUnitOfWork
{
    public CustomerServiceDbContext(DbContextOptions options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerServiceDbContext).Assembly);
    }

}
