using MediatR;

namespace CustomerService.Application.Abstractions;

public interface ICommand : IRequest { }

public interface ICommand<TResult> : IRequest<TResult> { }
