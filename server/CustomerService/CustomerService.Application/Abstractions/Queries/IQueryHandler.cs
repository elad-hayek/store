using MediatR;

namespace CustomerService.Application.Abstractions;

internal interface IQueryHandler<TQuery, TResult> : IRequestHandler<TQuery, TResult> 
    where TQuery : IQuery<TResult> { }
