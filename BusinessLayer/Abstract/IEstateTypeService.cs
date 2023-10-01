﻿using CoreLayer.Responses.Results.Abstract;
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
        Task<IResult> AddAsync(User entity);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> UpdateAsync(int id);
        Task<IDataResult<User>> GetByIdAsync(int id); 
        Task<IDataResult<IEnumerable<User>>> GetAllListAsync();
    }
}
