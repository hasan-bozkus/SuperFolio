﻿using BusinnesLayer.Abstract;
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
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill entity)
        {
            _skillDal.Insert(entity);
        }

        public void TDelete(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public List<Skill> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public Skill TGetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
