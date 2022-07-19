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
    public class NewsController : Controller
    {
        NewsManager newsManager = new NewsManager(new EfNewDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = newsManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult NewsDetails(int id)
        {
            ViewBag.i = id;
            var values = newsManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult NewsDetails(News news)
        {
            return View();
        }
    }
}

