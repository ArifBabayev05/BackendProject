using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        public IViewComponentResult Invoke()
        {
            var values = sliderManager.TGetList();
            return View(values);
        }
    }
}

