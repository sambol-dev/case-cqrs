using CqrsSample.Application.Common;

using CqrsSample.Domain.Todos;
using MediatR;

namespace CqrsSample.Application.Todos.Commands;

public sealed class CompleteTodoCommandHandler 
    : IRequestHandler<CompleteTodoCommand, Result>
{

    public async Task<Result> Handle(
        CompleteTodoCommand command,
        CancellationToken cancellationToken)
    {
        var todoId = new TodoId(command.TodoId);

        var todo = TodoStore.GetById(todoId);

        if (todo is null)
            return await Task.FromResult(Result.Failure("Todo nao encontrado"));
        
        todo.Complete(DateTime.UtcNow);

        return await Task.FromResult(Result.Success());
    }
}
