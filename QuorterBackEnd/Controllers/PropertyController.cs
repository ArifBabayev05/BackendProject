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
    public class PropertyController : Controller
    {
        PropertyManager propertyManager = new PropertyManager(new EfNewsDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = propertyManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult PropertyDetails(int id)
        {
            ViewBag.i = id;
            var values = propertyManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult PropertyDetails(Property property)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Addlist(int id)
        {
            ViewBag.i = id;
            var values = propertyManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Addlist(Property property)
        {
            return View();
        }
    }
}

