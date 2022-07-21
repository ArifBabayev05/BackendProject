using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.MemberDashboard
{
    public class _DeletePartial : ViewComponent
    {
        FeatureManager team = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = team.TGetList();
            return View(values);
        }
    }
}

