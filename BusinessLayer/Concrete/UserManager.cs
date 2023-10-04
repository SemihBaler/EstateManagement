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
    public class UserManager:IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IUnitOfWork _unitOfWork;

        public UserManager(IUserDal userDal, IUnitOfWork unitOfWork)
        {
            _userDal = userDal;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddAsync(User entity)
        {
            await _userDal.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Kullanıcı Ekleme İşlemi  Başarılı ...");

        }
        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            _unitOfWork.Commit();
            return new SuccsessResult("Kullanıcı Güncelleme İşlemi  Başarılı ...");
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _userDal.DeleteAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Kullanıcı Silme İşlemi  Başarılı ...");
        }
        public async Task<IResult> RemoveAsync(int id)
        {
            await _userDal.RemoveAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessResult("Kullanıcı Kaldırma İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<IEnumerable<User>>> GetAllListAsync()
        {
            var result = await _userDal.GetAllListAsync();
            return new SuccsessDataResult<IEnumerable<User>>(result, "Tüm Kullanıcıları Listeleme İşlemi  Başarılı ...");
        }

        public async Task<IDataResult<User>> GetByIdAsync(int id)
        {
            var result = await _userDal.GetByIdAsync(id);
            await _unitOfWork.CommitAsync();
            return new SuccsessDataResult<User>(result, "Id'ye Göre Kullanıcı Getirildi ...");
        }
    }
}
