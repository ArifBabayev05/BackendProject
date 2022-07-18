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

    public class ShopController : Controller
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = _featureManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ShopDetails(int id)
        {
            ViewBag.i = id;
            var values = _featureManager.TGetById(id);
            return View(values);
        }

        [HttpPost ]
        public IActionResult ShopDetails(Feature2 feature2)
        {
            return View();
        }
    }
}

