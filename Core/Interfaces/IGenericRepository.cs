using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    // we are setting up a constraint so only the classes that derive from "where" the BaseEntity have acces to this.
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}