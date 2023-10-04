using CoreLayer.DataAccess.EntityFramework.Abstract;
using CoreLayer.UnitOfWork.Abstract;
using EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataAccess.EntityFramework.Concrete
{
    public class EfBaseRepository<TEntity,TContext> : IEfBaseRepository<TEntity> where TEntity : BaseEntity,IEntity,new() where TContext : DbContext, new()
    {
        private readonly TContext _context;

        public EfBaseRepository(TContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
                await _context.Set<TEntity>().AddAsync(entity);
        }
        public async Task DeleteAsync(int id)
        {
            var entity=await _context.Set<TEntity>().FindAsync(id);
            entity.DeletedDate = DateTime.Now;
            entity.Status = Status.Passive;
            _context.Entry(entity).State=EntityState.Modified;
            
        }
        public async Task RemoveAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            entity.DeletedDate = DateTime.Now;
            _context.Entry(entity).State = EntityState.Deleted;
        }
        public void Update(TEntity entity)
        {
            // Önce veriyi güncellemek için DbSet'ten varlığı alın
            entity.UpdatedDate = DateTime.Now;
            entity.Status = Status.Modified;
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task<IEnumerable<TEntity>> GetAllListAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            var value = await _context.Set<TEntity>().FindAsync(id);
            if(value != null)
            {
                _context.Entry(value).State = EntityState.Detached;  //Memoride izlenmemesi için 
            }
            return value;
        }

        public IQueryable<TResult> GetFilteredListAsync<TResult>(Expression<Func<TEntity, TResult>> select,
                                                                 Expression<Func<TEntity, bool>> filter = null,
                                                                 Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                                 Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            // İlişkili verileri dahil etme
            if (includes != null)
            {
                query = includes(query);
            }
            // Filtreleme
            if (filter != null)
            {
                query = query.Where(filter);
            }
            // Sıralama
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            var result = query.Select(select);

            return result;

        }

      
    }
}
