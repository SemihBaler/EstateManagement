using BusinessLayer.Abstract;
using CoreLayer.Responses.Results.Abstract;
using CoreLayer.Responses.Results.Concrete;
using CoreLayer.UnitOfWork.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EstateTypeManager:IEstateTypeService
    {
        private readonly IEstateTypeDal _estateTypeDal;
        private readonly IUnitOfWork _unitOfWork;

        public EstateTypeManager(IEstateTypeDal estateTypeDal, IUnitOfWork unitOfWork)
        {
            _estateTypeDal = estateTypeDal;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddAsync(EstateType entity)
        {
            await _estateTypeDal.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Emlak Türü Ekleme İşlemi  Başarılı ...");

        }
        public IResult Update(EstateType entity)
        {
            _estateTypeDal.Update(entity);
            entity.Status = Status.Modified;
            _unitOfWork.Commit();
            return new SuccsessResult("Emlak Türü Güncelleme İşlemi  Başarılı ...");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _estateTypeDal.DeleteAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Emlak Türü Silme İşlemi  Başarılı ...");
        }
        public async Task<IResult> RemoveAsync(int id)
        {
            await _estateTypeDal.RemoveAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Emlak Türü Kaldırma İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<IEnumerable<EstateType>>> GetAllListAsync()
        {
            var result = await _estateTypeDal.GetAllListAsync();
            return new SuccsessDataResult<IEnumerable<EstateType>>(result, "Tüm Emlak Türleri Listeleme İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<EstateType>> GetByIdAsync(int id)
        {
            var result = await _estateTypeDal.GetByIdAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessDataResult<EstateType>(result, "Id'ye Göre Emlak Türü Getirildi ...");
        }

    }
}
