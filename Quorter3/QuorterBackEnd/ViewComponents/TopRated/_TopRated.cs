using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.TopRated
{
    public class _TopRated : ViewComponent
    {
        FeatureManager teamManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = teamManager.TGetList();
            return View(values);
        }
    }
}

