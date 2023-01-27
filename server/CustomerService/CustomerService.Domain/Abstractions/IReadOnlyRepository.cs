using CustomerService.Domain.Primitives;
using System.Linq.Expressions;

namespace CustomerService.Domain.Abstractions;

public interface IReadOnlyRepository<T> where T : Entity
{
    IReadOnlyCollection<T> GetAll();
    T GetById(int id); 
    IReadOnlyCollection<T> GetByCiriteria(Expression<Func<T, bool>> crateria);
}
