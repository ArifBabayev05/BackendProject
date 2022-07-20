using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDal LocationDal;

        public LocationManager(ILocationDal locationDal)
        {
            LocationDal = locationDal;
        }

        public void TAdd(Location t)
        {
            LocationDal.Insert(t);
        }

        public void TDelete(Location t)
        {
            LocationDal.Delete(t);
        }

        public Location TGetById(int id)
        {
            return LocationDal.GetById(id);
        }

        public List<Location> TGetList()
        {
            return LocationDal.GetList();
        }

        public void TUpdate(Location t)
        {
            throw new NotImplementedException();
        }
    }
}

