using CqrsSample.Application.Common;
using MediatR;

namespace CqrsSample.Application.Todos.Queries;

public sealed class GetTodoQueryHandler : IRequestHandler<GetTodoQuery, Result<TodoDto>>
{
    public Task<Result<TodoDto>> Handle(
        GetTodoQuery request,
        CancellationToken cancellationToken
    )
    {
        var dto = new TodoDto(
            request.TodoId,
            "CQRS com MediatR"
        );

        return Task.FromResult(Result<TodoDto>.Success(dto));
    }
}
