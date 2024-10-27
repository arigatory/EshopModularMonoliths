namespace Ordering.Orders.Events;
public record OrderCreatedEvent(Order Order)
    : IDomaintEvent;
