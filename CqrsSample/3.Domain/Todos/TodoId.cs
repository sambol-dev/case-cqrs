namespace CqrsSample.Domain.Todos;

public readonly record struct TodoId(Guid Value)
{
    public static TodoId New() => new(Guid.NewGuid());
}