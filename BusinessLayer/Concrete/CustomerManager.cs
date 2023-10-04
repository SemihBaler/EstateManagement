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
    public class CustomerManager :ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerManager(ICustomerDal categoryDal, IUnitOfWork unitOfWork)
        {
            _customerDal = categoryDal;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddAsync(Customer entity)
        {
            await _customerDal.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Müşteri Ekleme İşlemi  Başarılı ...");

        }
        public IResult Update(Customer category)
        {
            _customerDal.Update(category);
            _unitOfWork.Commit();
            return new SuccsessResult("Müşteri Güncelleme İşlemi  Başarılı ...");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _customerDal.DeleteAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Müşteri Silme İşlemi  Başarılı ...");
        }
        public async Task<IResult> RemoveAsync(int id)
        {
            await _customerDal.RemoveAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Müşteri Kaldırma İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<IEnumerable<Customer>>> GetAllListAsync()
        {
            var result = await _customerDal.GetAllListAsync();
            return new SuccsessDataResult<IEnumerable<Customer>>(result, "Tüm Müşterileri Listeleme İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<Customer>> GetByIdAsync(int id)
        {
            var result = await _customerDal.GetByIdAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessDataResult<Customer>(result, "Id'ye Göre Müşteri Getirildi ...");
        }

    }
}
