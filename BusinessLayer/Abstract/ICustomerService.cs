using CoreLayer.Responses.Results.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        Task<IResult> AddAsync(Customer entity);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> UpdateAsync(int id);
        Task<IDataResult<Customer>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<Customer>>> GetAllListAsync();
    }
}
