namespace Shared.DDD;

public interface IAggregate<T> : IAggregate, IEntity<T>
{
    
}

public interface IAggregate : IEntity
{
    IReadOnlyList<IDomaintEvent> DomainEvents { get; }
    IDomaintEvent[] ClearDomainEvents();
}
