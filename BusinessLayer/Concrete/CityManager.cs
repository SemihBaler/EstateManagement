using BusinessLayer.Abstract;
using CoreLayer.Responses.Results.Abstract;
using CoreLayer.Responses.Results.Concrete;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CityManager : ICityService
    {   
        private readonly ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public  async Task<IDataResult<IEnumerable<City>>> GetAllListAsync()
        {
            var result  = await _cityDal.GetAllListAsync();
            return new SuccsessDataResult<IEnumerable<City>>(result,"Tüm Şehirleri Listelediniz...");   
        }
    }
}
