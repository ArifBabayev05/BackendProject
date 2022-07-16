using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

