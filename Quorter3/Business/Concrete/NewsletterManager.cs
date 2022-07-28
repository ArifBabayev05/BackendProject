using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void TAdd(Newsletter t)
        {
            _newsletterDal.Insert(t);
        }

        public void TDelete(Newsletter t)
        {
            _newsletterDal.Delete(t);
        }

        public void TUpdate(Newsletter t)
        {
            throw new NotImplementedException();

        }

        public List<Newsletter> TGetList()
        {
            return _newsletterDal.GetList();
        }

        public Newsletter TGetById(int id)
        {
            return _newsletterDal.GetById(id);
        }
    }
}

