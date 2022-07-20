using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;


namespace Business.Concrete
{
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(MainSlider t)
        {
            _sliderDal.Insert(t);
        }

        public void TDelete(MainSlider t)
        {
            _sliderDal.Delete(t);
        }

        public MainSlider TGetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public List<MainSlider> TGetList()
        {
            return _sliderDal.GetList();
        }

        public void TUpdate(MainSlider t)
        {
            throw new NotImplementedException();
        }
    }
}

