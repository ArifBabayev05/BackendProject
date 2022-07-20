using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Location
{
    public class _LocationPartial : ViewComponent
    {
        LocationManager locationManager = new LocationManager(new EfLocationDal());
        public IViewComponentResult Invoke()
        {
            var values = locationManager.TGetList();
            return View(values);
        }
    }
}

