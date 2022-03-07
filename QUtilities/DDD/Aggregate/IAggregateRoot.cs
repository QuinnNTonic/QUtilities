using System.Collections.Generic;
using QUtilities.DomainEvent;

namespace QUtilities.Aggregate
{
    public interface IAggregateRoot
    {
        IReadOnlyList<IDomainEvent> DomainEvents { get; }

        void ClearEvents();
    }
}