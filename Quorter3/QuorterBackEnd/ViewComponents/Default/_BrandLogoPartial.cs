using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _BrandLogoPartial : ViewComponent
    {
            CarouselManager carouselManager =  new CarouselManager(new EfCarouselDal());
            public IViewComponentResult Invoke()
            {
                var values = carouselManager.TGetList();
                return View(values);
            }
    }
}

