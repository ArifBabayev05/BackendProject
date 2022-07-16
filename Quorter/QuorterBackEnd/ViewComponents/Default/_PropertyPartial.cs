using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _PropertyPartial : ViewComponent
    {

        PropertyManager propertyManager = new PropertyManager(new EfPropertyDal()); 
        public IViewComponentResult Invoke()
        {
            var values = propertyManager.TGetList();
            return View(values);
        }
    }
}

