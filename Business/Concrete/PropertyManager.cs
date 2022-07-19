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
            _propertyDal.Insert(t);
        }

        public void TDelete(Property t)
        {
            _propertyDal.Delete(t);
        }

        public Property TGetById(int id)
        {
            return _propertyDal.GetById(id);
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

