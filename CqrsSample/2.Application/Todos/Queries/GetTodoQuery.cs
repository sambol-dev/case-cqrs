using CqrsSample.Application.Abstractions.Messaging;

namespace CqrsSample.Application.Todos.Queries;

public sealed record GetTodoQuery(Guid TodoId) : IQuery<TodoDto>;

public sealed record TodoDto(Guid Id, string Title);