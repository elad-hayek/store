using CustomerService.Domain.Abstractions;

namespace CustomerService.Presistence.Repositories;

internal sealed class UnitOfWork : IUnitOfWork
{
    private readonly CustomerServiceDbContext _dbContext;

    public UnitOfWork(CustomerServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.SaveChangesAsync();
    }
}
