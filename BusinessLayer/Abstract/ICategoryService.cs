using CoreLayer.Responses.Results.Abstract;
using CoreLayer.Responses.Results.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        Task<IResult> AddAsync(Category entity);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> RemoveAsync(int id);
        IResult Update(Category entity);
        Task<IDataResult<Category>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<Category>>> GetAllListAsync();
    }
}
