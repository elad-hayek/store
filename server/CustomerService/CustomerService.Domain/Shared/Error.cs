using CustomerService.Domain.Abstractions;

namespace CustomerService.Domain.Shared;

public class Error : EqualById<Error, string> {
    public Error(string id, string message) : base(id)
    {
        Message = message;
    }

    public string Message { get; }
}
