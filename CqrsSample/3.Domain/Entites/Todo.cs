namespace CqrsSample.Domain.Entities;

public class Todo
{
    public Guid Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public bool IsCompleted { get; private set; }
    public DateTime? CompletedAt { get; private set; }

    public Todo(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
        IsCompleted = false;
    }

    public void Complete(DateTime completedAt)
    {
        if (IsCompleted)
            throw new InvalidOperationException("Todo ja finalizado");
        
        IsCompleted = true;
        CompletedAt = completedAt;
    }
}