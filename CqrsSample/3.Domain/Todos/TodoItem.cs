using CqrsSample.Domain.Common;
using CqrsSample.Domain.Todos.Events;

namespace CqrsSample.Domain.Todos;

public sealed class TodoItem : AggregateRoot<TodoId>
{
    public string Title { get; private set; } = default!;
    public bool IsCompleted { get; private set; }
    public DateTime? CompletedAt { get; private set; }

    public TodoItem(TodoId id, string title)
    {
        Id = id;
        Title = title;
        IsCompleted = false;
    }

    public void Complete(DateTime completedAt)
    {
        if (IsCompleted)
            throw new InvalidOperationException("Todo já concluido");

        IsCompleted = true;
        CompletedAt = completedAt;

        Raise(new TodoCompletedDomainEvent(Id));
    }
}