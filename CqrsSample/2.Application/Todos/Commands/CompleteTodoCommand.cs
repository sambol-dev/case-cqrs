using CqrsSample.Application.Abstractions.Messaging;

namespace CqrsSample.Application.Todos.Commands;

public sealed record CompleteTodoCommand(Guid TodoId) : ICommand;