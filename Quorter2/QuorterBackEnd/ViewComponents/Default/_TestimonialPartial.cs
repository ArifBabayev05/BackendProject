using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        TestimonialManager testimonial = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonial.TGetList();
            return View(values);
        }
    }
}

