using CqrsSample.Domain.Common;

namespace CqrsSample.Domain.Todos.Events;

public sealed record TodoCompletedDomainEvent(TodoId TodoId) 
    : DomainEvent(DateTime.Now);