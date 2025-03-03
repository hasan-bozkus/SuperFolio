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
    public class UserMessageManager : IUserMessageService
    {
        private readonly IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void TAdd(UserMessage entity)
        {
            _userMessageDal.Insert(entity);
        }

        public void TDelete(UserMessage entity)
        {
            _userMessageDal.Delete(entity);
        }

        public UserMessage TGetByID(int id)
        {
            return _userMessageDal.GetByID(id);
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public List<UserMessage> TGetUserMessagesWithUser()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }

        public void TUpdate(UserMessage entity)
        {
            _userMessageDal.Update(entity);
        }
    }
}
