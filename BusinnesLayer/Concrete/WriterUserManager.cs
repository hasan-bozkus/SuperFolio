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
    public class WriterUserManager : IWriterUserService
    {
        private readonly IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void TAdd(WriterUser entity)
        {
            _writerUserDal.Insert(entity);
        }

        public void TDelete(WriterUser entity)
        {
            _writerUserDal.Delete(entity);
        }

        public List<WriterUser> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public WriterUser TGetByID(int id)
        {
            return _writerUserDal.GetByID(id);
        }

        public List<WriterUser> TGetList()
        {
            return _writerUserDal.GetList();
        }

        public void TUpdate(WriterUser entity)
        {
            _writerUserDal.Update(entity);
        }
    }
}
