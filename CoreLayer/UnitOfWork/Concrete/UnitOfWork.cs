using CoreLayer.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.UnitOfWork.Concrete
{
    public class UnitOfWork<T> : IUnitOfWork where  T : DbContext, new()
    {
        private readonly T _context;
        public UnitOfWork(T dataBase)
        {
            _context = dataBase;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
