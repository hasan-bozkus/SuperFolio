using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(User entity)
        {
            _userDal.Insert(entity);
        }

        public void TDelete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User TGetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<User> TGetList()
        {
            return _userDal.GetList();
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
