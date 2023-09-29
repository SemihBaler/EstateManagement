using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataAccess.EntityFramework.Abstract
{
    public interface IEfBaseRepository<TEntity> where TEntity : class
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
