using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature2 t)
        {
            throw new NotImplementedException();
        }

        public Feature2 TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature2> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature2 t)
        {
            throw new NotImplementedException();
        }
    }
}

