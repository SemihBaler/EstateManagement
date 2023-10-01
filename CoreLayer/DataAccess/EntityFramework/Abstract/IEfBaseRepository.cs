using EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace CoreLayer.DataAccess.EntityFramework.Abstract
{
    public interface IEfBaseRepository<TEntity> where TEntity : class,IEntity, new()
    {
        Task AddAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllListAsync();
        IQueryable<TResult> GetFilteredListAsync<TResult>( Expression<Func<TEntity, TResult>> select,
                                                                 Expression<Func<TEntity, bool>> filter = null,
                                                                 Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                                 Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);
    }
}
