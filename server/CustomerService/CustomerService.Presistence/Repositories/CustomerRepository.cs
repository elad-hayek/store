using CustomerService.Domain.Abstractions;
using CustomerService.Domain.Entities;
using System.Linq.Expressions;

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
       return _dbContext.Set<Customer>().ToList().AsReadOnly();
    }

    public IReadOnlyCollection<Customer> GetByCiriteria(Expression<Func<Customer, bool>> crateria)
    {
        return _dbContext.Set<Customer>().Where(crateria).ToList().AsReadOnly();
    }

    public Customer? GetById(int id)
    {
        return _dbContext.Set<Customer>().FirstOrDefault(x=>x.Id == id);
    }

    public void Insert(Customer entity)
    {
        _dbContext.Set<Customer>().Add(entity);
    }

    public void Update(Customer entity, int updatingUserId)
    {
        throw new NotImplementedException();
    }
}
