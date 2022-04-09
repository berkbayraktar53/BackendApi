using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User entity)
        {
            _userDal.Add(entity);
            return new SuccessDataResult<User>(Messages.UserAdded);
        }

        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessDataResult<User>(Messages.UserDeleted);
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(x => x.Email == email);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(x => x.UserId == id));
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IDataResult<List<User>> GetList()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList().ToList());
        }

        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessDataResult<User>(Messages.UserUpdated);
        }
    }
}