using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Faq
{
    public class _FaqPartial : ViewComponent
    {
        FaqManager teamManager = new FaqManager(new EfFaqDal());
        public IViewComponentResult Invoke()
        {
            var values = teamManager.TGetList();
            return View(values);
        }
    }
}

