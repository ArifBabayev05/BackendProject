using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DAL.EntityFramework;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class TeamController : Controller
    {
        TeamManager teamManager = new TeamManager(new EfTeamDal());

        [HttpGet]
        public IActionResult Add(int id)
        {
            //ViewBag.i = id;
            //var values = teamManager.TGetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult Add(Team team)
        {
            teamManager.TAdd(team);

            return RedirectToAction("Index", "Member");

        }
    }
}

