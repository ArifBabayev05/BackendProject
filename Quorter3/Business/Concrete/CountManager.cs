using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class CountManager : ICounterService
    {
        ICounterDal _counterDal;

        public CountManager(ICounterDal counterDal)
        {
            _counterDal = counterDal;
        }

        public void TAdd(Counter t)
        {
            _counterDal.Insert(t);
        }

        public void TDelete(Counter t)
        {
            _counterDal.Delete(t);
        }

        public Counter TGetById(int id)
        {
            return _counterDal.GetById(id);
        }

        public List<Counter> TGetList()
        {
            return _counterDal.GetList();
        }

        public void TUpdate(Counter t)
        {
            throw new NotImplementedException();
        }
    }
}

