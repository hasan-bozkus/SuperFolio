using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDay;

        public AboutManager(IAboutDal aboutDay)
        {
            _aboutDay = aboutDay;
        }

        public void TAdd(About entity)
        {
            _aboutDay.Insert(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDay.Delete(entity);
        }

        public List<About> TGetbyFilter(string p)
        {
            throw new NotImplementedException();
        }

        public About TGetByID(int id)
        {
            return _aboutDay.GetByID(id);
        }

        public List<About> TGetList()
        {
            return _aboutDay.GetList();
        }

        public void TUpdate(About entity)
        {
            _aboutDay.Update(entity);
        }
    }
}
