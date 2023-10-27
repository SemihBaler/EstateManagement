using BusinessLayer.Abstract;
using CoreLayer.Responses.Results.Abstract;
using CoreLayer.Responses.Results.Concrete;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DistrictManager:IDistrictService 
    {
        private readonly IDistrcitDal _districtDal;

        public DistrictManager(IDistrcitDal districtDal)
        {
            _districtDal = districtDal;
        }

        public async Task<IDataResult<IEnumerable<District>>> GetAllListAsync()
        {
            var result = await _districtDal.GetAllListAsync();
            return new SuccsessDataResult<IEnumerable<District>>(result,"Tüm Şehirlere Ait İlçeleri Listelediniz...");
        }

        public async Task<IDataResult<IEnumerable<District>>> GetByCityIdAsync(int id)
        {
            var district = await _districtDal.GetAllListAsync();
            var result = district.Where(x => x.CityId == id);
            return new SuccsessDataResult<IEnumerable<District>>(result,"Seçilen İle Göre İlçeleri Listelediniz...");
        }
    }
}
