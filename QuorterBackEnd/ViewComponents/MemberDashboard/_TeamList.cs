using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.MemberDashboard
{
    public class _TeamList : ViewComponent
    {
        TeamManager team = new TeamManager(new EfTeamDal());
        public IViewComponentResult Invoke()
        {
            var values = team.TGetList();
            return View(values); 
        }
    }
}

