using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Controllers
{
    public class ServiceController : Controller
    {
        MainFocusManager mainFocusManager = new MainFocusManager(new EfMainFocusDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = mainFocusManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ServiceDetails(int id)
        {
            ViewBag.i = id;
            var values = mainFocusManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult ServiceDetails(MainFocusManager mainfocus)
        {
            return View();
        }
    }
}

