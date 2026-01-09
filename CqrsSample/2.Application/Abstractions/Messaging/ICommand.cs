using CqrsSample.Application.Common;
using MediatR;

namespace CqrsSample.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>;
public interface ICommand<TResponse> : IRequest<Result<TResponse>>;