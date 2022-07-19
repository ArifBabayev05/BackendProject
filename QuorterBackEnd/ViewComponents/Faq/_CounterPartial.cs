using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Faq
{
    public class _CounterPartial : ViewComponent
    {
        CountManager counterManager = new CountManager(new EfCountDal());
        public IViewComponentResult Invoke()
        {
            var values = counterManager.TGetList();
            return View(values);
        }
    }
}

