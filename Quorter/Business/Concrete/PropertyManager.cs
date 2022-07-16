using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class PropertyManager : IPropertyService
    {
        IPropertyDal _propertyDal;

        public PropertyManager(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public void TAdd(Property t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Property t)
        {
            throw new NotImplementedException();
        }

        public Property TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Property> TGetList()
        {
           return _propertyDal.GetList();
        }

        public void TUpdate(Property t)
        {
            throw new NotImplementedException();
        }
    }
}

