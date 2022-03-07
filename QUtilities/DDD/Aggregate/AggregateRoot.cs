using System;
using System.Collections.Generic;
using QUtilities.DomainEvent;

namespace QUtilities.Aggregate
{
    public abstract class AggregateRoot<TID> : Entity<TID>, IAggregateRoot
    {
        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        public virtual IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents;

        //protected AggregateRoot(TID Id):base(Id)
        //{
        //}

        protected virtual void RaiseDomainEvent(IDomainEvent newEvent)
        {
            _domainEvents.Add(newEvent);
        }

        public virtual void ClearEvents()
        {
            _domainEvents.Clear();
        }
    }
}
