using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _NewsPartial : ViewComponent
    {
        NewsManager newsManager = new NewsManager(new EfNewDal());
        public IViewComponentResult Invoke()
        {
            var values = newsManager.TGetList();
            return View(values);
        }
    }
}

