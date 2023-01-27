using CustomerService.Domain.Abstractions;
using CustomerService.Domain.Entities;

namespace CustomerService.Presistence.Repositories;

public sealed class CustomerRepository : ICustomerRepository
{
    private readonly CustomerServiceDbContext _dbContext;

    public CustomerRepository(CustomerServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Delete(Customer entity, int deletingUserId)
    {
        throw new NotImplementedException();
    }

    public void DeleteById(int id, int deletingUserId)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyCollection<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public IReadOnlyCollection<Customer> GetByCiriteria(Predicate<Customer> crateria)
    {
        throw new NotImplementedException();
    }

    public Customer GetById(int id)
    {
        throw new NotImplementedException();
    }

    public int Insert(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity, int updatingUserId)
    {
        throw new NotImplementedException();
    }
}
