 
using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Default
{
    public class _MainFocusPartial : ViewComponent
    {
        MainFocusManager mainFocusManager = new MainFocusManager(new EfMainFocusDal());
        public IViewComponentResult Invoke()
        {
            var values = mainFocusManager.TGetList();
            return View(values);
        }
    }
}

