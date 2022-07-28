using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.About
{
    public class _AboutPartial : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke(int id)
        {

            var values = aboutManager.TGetList();
            return View(values);
        }

    }
}

