using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class FaqManager : IFaqService
    {
        IFaqDal _faqDal;
        public FaqManager(IFaqDal faqDal)
        {
            _faqDal = faqDal;
        }

        public void TAdd(Faq t)
        {
            _faqDal.Insert(t);
        }

        public void TDelete(Faq t)
        {
            _faqDal.Delete(t);
        }

        public Faq TGetById(int id)
        {
            return _faqDal.GetById(id);
        }

        public List<Faq> TGetList()
        {
            return _faqDal.GetList();
        }

        public void TUpdate(Faq t)
        {
            throw new NotImplementedException();
        }
    }
}

