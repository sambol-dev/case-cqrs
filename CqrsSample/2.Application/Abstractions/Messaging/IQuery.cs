using CqrsSample.Application.Common;
using MediatR;

namespace CqrsSample.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;