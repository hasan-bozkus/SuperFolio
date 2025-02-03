﻿using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        public void TAdd(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDal.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDal.GetList();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
