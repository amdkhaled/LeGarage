namespace LeGarage.Core.Interfaces.Repositories.BaseRepo
{
    public interface IBaseRepo<T> where T : class
    {

        Task<T> AddAsyncGeneric(T entity);

        Task UpdateAsyncGeneric(T entity);

        Task DeleteAsyncGeneric(T entity);
        Task<T?> GetByIdAsyncGeneric(int id);

        Task<IEnumerable<T>> GetAllAsyncGeneric();

        //Task<T?> GetByIdAsyncGeneric(int id, params Expression<Func<T, object>>[] includeProperties);

        //Task AttachAsyncGeneric(T entity, EntityState entityState);

        //Task DetachAsyncGeneric(T entity);

        //Task<IEnumerable<T>> GetAllWithIncludesAsyncGeneric(params Expression<Func<T, object>>[] includeProperties);
    }
}
