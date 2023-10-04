using BusinessLayer.Abstract;
using CoreLayer.Responses.Results.Abstract;
using CoreLayer.Responses.Results.Concrete;
using CoreLayer.UnitOfWork.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Context;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EstateManager :IEstateService
    {
        private readonly IEstateDal _estateDal;
        private readonly IUnitOfWork _unitOfWork;

        public EstateManager(IEstateDal estateDal, IUnitOfWork unitOfWork)
        {
            _estateDal = estateDal;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddAsync(Estate entity)
        {
            await _estateDal.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Emlak Ekleme İşlemi  Başarılı ...");

        }
        public IResult Update(Estate entity)
        {
            _estateDal.Update(entity);
            _unitOfWork.Commit();
            return new SuccsessResult("Emlak Güncelleme İşlemi  Başarılı ...");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _estateDal.DeleteAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Emlak Silme İşlemi  Başarılı ...");
        }
        public async Task<IResult> RemoveAsync(int id)
        {
            await _estateDal.RemoveAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Emlak Kaldırma İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<IEnumerable<Estate>>> GetAllListAsync()
        {
            var result = await _estateDal.GetAllListAsync();
            return new SuccsessDataResult<IEnumerable<Estate>>(result, "Tüm Emlakları Listeleme İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<Estate>> GetByIdAsync(int id)
        {
            var result = await _estateDal.GetByIdAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessDataResult<Estate>(result, "Id'ye Göre Emlak Getirildi ...");
        }
    }
}
