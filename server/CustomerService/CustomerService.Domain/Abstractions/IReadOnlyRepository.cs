using CustomerService.Domain.Primitives;

namespace CustomerService.Domain.Abstractions;

public interface IReadOnlyRepository<T> where T : Entity
{
    IReadOnlyCollection<T> GetAll();
    T GetById(int id); 
    IReadOnlyCollection<T> GetByCiriteria(Predicate<T> crateria);
}
