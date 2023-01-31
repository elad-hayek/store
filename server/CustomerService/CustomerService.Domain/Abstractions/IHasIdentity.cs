namespace CustomerService.Domain.Abstractions;

public interface IHasIdentity<T> where T : notnull
{
    T Id { get; protected init; }
}
