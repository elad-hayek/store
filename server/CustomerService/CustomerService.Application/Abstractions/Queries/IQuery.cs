using MediatR;

namespace CustomerService.Application.Abstractions;

public interface IQuery<TResult> : IRequest<TResult> { }