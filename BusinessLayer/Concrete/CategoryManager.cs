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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(ICategoryDal categoryDal,IUnitOfWork unitOfWork)
        {
            _categoryDal=categoryDal;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddAsync(Category entity)
        {
            await _categoryDal.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Kategori Ekleme İşlemi  Başarılı ...");

        }
           public IResult Update(Category entity)
        {
           _categoryDal.Update(entity);
            entity.Status = Status.Modified;
           _unitOfWork.Commit();
            return new SuccsessResult("Kategori Güncelleme İşlemi  Başarılı ...");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _categoryDal.DeleteAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Kategori Silme İşlemi  Başarılı ...");
        }
        public async Task<IResult> RemoveAsync(int id)
        {
            await _categoryDal.RemoveAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Kategori Kaldırma İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<IEnumerable<Category>>> GetAllListAsync()
        {
            var result =await _categoryDal.GetAllListAsync();
            return new SuccsessDataResult<IEnumerable<Category>>(result,"");
        }

        public async Task<IDataResult<Category>> GetByIdAsync(int id)
        {
            var result = await _categoryDal.GetByIdAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessDataResult<Category>(result, "Id'ye Göre Category Getirildi ...");
        }

     
    }
}
