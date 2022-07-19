using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DAL.EntityFramework;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Controllers
{
    public class TeamController : Controller
    {
        TeamManager _teamManager= new TeamManager(new EfTeamDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = _teamManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult TeamDetails(int id)
        {
            ViewBag.i = id;
            var values = _teamManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult TeamDetails(Team team)
        {
            return View();
        }
    }
}

