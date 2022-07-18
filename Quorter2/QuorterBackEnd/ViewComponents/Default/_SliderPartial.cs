using System;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

