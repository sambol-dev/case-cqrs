using CqrsSample.Domain.Todos;

namespace CqrsSample.Application.Todos;

public static class TodoStore
{
    private static readonly List<TodoItem> _todos = new();

    public static TodoItem? GetById(TodoId id)
        => _todos.SingleOrDefault(t => t.Id == id);
    
    public static void Add(TodoItem todo) => _todos.Add(todo);

    public static IReadOnlyList<TodoItem> GetAll() => _todos;
}