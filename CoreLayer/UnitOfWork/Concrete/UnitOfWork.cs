using CoreLayer.UnitOfWork.Abstract;
using DataAccesLayer.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EstateDbContext _context;
        public UnitOfWork(EstateDbContext dataBase)
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
