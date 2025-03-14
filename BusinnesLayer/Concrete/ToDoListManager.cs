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
    public class ToDoListManager : IToDoListService
    {
        private readonly IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void TAdd(ToDoList entity)
        {
            _toDoListDal.Insert(entity);
        }

        public void TDelete(ToDoList entity)
        {
            _toDoListDal.Delete(entity);
        }

        public List<ToDoList> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetByID(int id)
        {
            return _toDoListDal.GetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public void TUpdate(ToDoList entity)
        {
            _toDoListDal.Update(entity);
        }
    }
}
