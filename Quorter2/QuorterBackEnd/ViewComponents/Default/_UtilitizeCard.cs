using System;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _UtilitizeCard : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

