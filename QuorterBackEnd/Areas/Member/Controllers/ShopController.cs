using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class ShopController : Controller
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}

