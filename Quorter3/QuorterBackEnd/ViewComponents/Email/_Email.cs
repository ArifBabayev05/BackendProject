using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Email
{
    public class _Email : ViewComponent
    {
        SendManager manager = new SendManager(new EfSendDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
        
    }
}

