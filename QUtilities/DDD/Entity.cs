using System;
using System.Collections.Generic;
using QUtilities.DomainEvent;

namespace QUtilities
{
    public abstract class Entity<TID>
    {
        protected Entity()
        {
        }

        protected Entity(TID Id)
        {
            this.Id = Id;
        }

        public virtual TID Id { get; protected set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Entity<TID> other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetRealType() != other.GetRealType())
                return false;

            if (Id.Equals(default(TID)) || other.Id.Equals(default(TID)))
                return false;

            return Id.Equals(other.Id);
        }

        public static bool operator ==(Entity<TID> a, Entity<TID> b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity<TID> a, Entity<TID> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetRealType().ToString() + Id).GetHashCode();
        }

        private Type GetRealType()
        {
            Type type = GetType();

            if (type.ToString().Contains("Castle.Proxies."))
                return type.BaseType;

            return type;
        }
    }
}
