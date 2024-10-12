using MediatR;

namespace Shared.DDD;

public interface IDomaintEvent : INotification
{
    public Guid EventId => Guid.NewGuid();
    public DateTime OccuredOn => DateTime.UtcNow;
    public string EventType => GetType().AssemblyQualifiedName!;
}
