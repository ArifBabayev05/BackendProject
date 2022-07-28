using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.TopProps
{
    public class _TopProps : ViewComponent
    {
        
         PropertyManager teamManager = new PropertyManager(new EfNewsDal());
        public IViewComponentResult Invoke()
        {
            var values = teamManager.TGetList();
            return View(values);
        }
    }
}

