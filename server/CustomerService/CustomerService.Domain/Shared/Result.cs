using CustomerService.Domain.Abstractions;

namespace CustomerService.Domain.Shared;

public class Result : EqualById<Result, string>
{
    protected internal Result(string id) : base(id)
    {

    }
}
