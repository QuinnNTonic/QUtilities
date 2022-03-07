using System;
using Ardalis.Specification;
using QUtilities.Aggregate;

namespace QUtilities.DDD.Repository
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}
