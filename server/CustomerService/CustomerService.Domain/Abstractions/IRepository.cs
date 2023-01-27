using CustomerService.Domain.Primitives;

namespace CustomerService.Domain.Abstractions;

public interface IRepository<T>:  IReadOnlyRepository<T> where T : Entity
{
    int Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
    void DeleteById(int id);
}
