using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Team
{
    public class _TeamPartial : ViewComponent
    {
        TeamManager teamManager = new TeamManager(new EfTeamDal());
        public IViewComponentResult Invoke()
        {
            var values = teamManager.TGetList();
            return View(values);
        }
    }
}

