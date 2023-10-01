using CoreLayer.Responses.Results.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEstateService
    {
        Task<IResult> AddAsync(Estate entity);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> UpdateAsync(int id);
        Task<IDataResult<Estate>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<Estate>>> GetAllListAsync();
    }
}
