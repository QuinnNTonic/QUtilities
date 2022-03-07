using System;
using Ardalis.Specification;
using QUtilities.Aggregate;

namespace QUtilities.Repository
{
    public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}
