namespace CqrsSample.Domain.Common;

public abstract class AggregateRoot<TId> : Entity<TId>
{
    private readonly List<DomainEvent> _domainEvents = [];

    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents;

    protected void Raise(DomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}