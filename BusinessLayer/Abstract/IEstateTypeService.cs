using CoreLayer.Responses.Results.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEstateTypeService 
    {
        Task<IResult> AddAsync(EstateType entity);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> RemoveAsync(int id);
        IResult Update(EstateType entity);
        Task<IDataResult<EstateType>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<EstateType>>> GetAllListAsync();
    }
}
