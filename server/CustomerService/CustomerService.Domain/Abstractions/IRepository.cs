using CustomerService.Domain.Primitives;

namespace CustomerService.Domain.Abstractions;

public interface IRepository<T>:  IReadOnlyRepository<T> where T : AggregateRoot
{
    void Insert(T entity);
    void Update(T entity, int updatingUserId);
    void Delete(T entity, int deletingUserId);
    void DeleteById(int id, int deletingUserId);
}
