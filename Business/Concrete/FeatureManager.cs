﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public List<Feature2> List(string p)
        {
            return _featureDal.GetListByFilter(x => x.Title == p);
        }


            


        public void TAdd(Feature2 t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature2 t)
        {
            _featureDal.Delete(t);
        }

        public Feature2 TGetById(int id)
        {
            return _featureDal.GetById(id) ;
        }

        public List<Feature2> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature2 t)
        {
            _featureDal.Update(t);
        }

        
    }
}

