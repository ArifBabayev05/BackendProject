using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void TAdd(Map t)
        {
            _locationDal.Insert(t);
        }

        public void TDelete(Map t)
        {
            _locationDal.Delete(t);
        }

        public Map TGetById(int id)
        {
            return  _locationDal.GetById(id);
        }

        public List<Map> TGetList()
        {
            return _locationDal.GetList();
        }

        public void TUpdate(Map t)
        {
            throw new NotImplementedException();
        }
    }
}

