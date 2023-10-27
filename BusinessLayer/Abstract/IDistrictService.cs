using CoreLayer.Responses.Results.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDistrictService
    {
        Task<IDataResult<IEnumerable<District>>> GetAllListAsync();
        Task<IDataResult<IEnumerable<District>>> GetByCityIdAsync(int id);
    }
}
