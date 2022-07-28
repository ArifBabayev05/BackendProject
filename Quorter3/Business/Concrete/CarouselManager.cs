using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class CarouselManager : ICarouselService
    {
        ICarouselDal _carouselDal;

        public CarouselManager (ICarouselDal carouselDal)
        {
            _carouselDal = carouselDal;
        }

        public void TAdd(Slider t)
        {
             _carouselDal.Insert(t);
        }

        public void TDelete(Slider t)
        {
            _carouselDal.Delete(t);
        }

        public Slider TGetById(int id)
        {
            return _carouselDal.GetById(id);
        }

        public List<Slider> TGetList()
        {
            return _carouselDal.GetList();
        }

        public void TUpdate(Slider t)
        {
            throw new NotImplementedException();
        }
    }
}

