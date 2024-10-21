namespace Shared.DDD;

public abstract class Aggregate<TId> : Entity<TId>, IAggregate<TId> where TId : struct
{
    private readonly List<IDomaintEvent> _domaintEvents = [];
    public IReadOnlyList<IDomaintEvent> DomainEvents => _domaintEvents.AsReadOnly();

    public void AddDomainEvent(IDomaintEvent domainEvent)
    {
        _domaintEvents.Add(domainEvent);
    }

    public IDomaintEvent[] ClearDomainEvents()
    {
        var result = _domaintEvents.ToArray();
        _domaintEvents.Clear();
        return result;
    }
}
