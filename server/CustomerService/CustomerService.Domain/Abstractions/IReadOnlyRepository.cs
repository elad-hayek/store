using CustomerService.Domain.Primitives;
using System.Linq.Expressions;

namespace CustomerService.Domain.Abstractions;

public interface IReadOnlyRepository<T, TIdType> 
    where T : AggregateRoot<TIdType>
    where TIdType : notnull
{
    IReadOnlyCollection<T> GetAll();
    T? GetById(TIdType id); 
    IReadOnlyCollection<T> GetByCiriteria(Expression<Func<T, bool>> crateria);
}
