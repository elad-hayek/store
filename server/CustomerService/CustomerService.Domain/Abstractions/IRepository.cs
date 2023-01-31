using CustomerService.Domain.Primitives;

namespace CustomerService.Domain.Abstractions;

public interface IRepository<T, TIdType>:  IReadOnlyRepository<T, TIdType> 
    where T : AggregateRoot<TIdType> 
    where TIdType : notnull
{
    void Insert(T entity);
    void Update(T entity, int updatingUserId);
    void Delete(T entity, int deletingUserId);
    void DeleteById(TIdType id, int deletingUserId);
}
