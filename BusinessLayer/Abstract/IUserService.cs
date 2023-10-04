using CoreLayer.Responses.Results.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService 
    {
        Task<IResult> AddAsync(User entity);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> RemoveAsync(int id);
        IResult Update(User entity);
        Task<IDataResult<User>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<User>>> GetAllListAsync();
    }
}
