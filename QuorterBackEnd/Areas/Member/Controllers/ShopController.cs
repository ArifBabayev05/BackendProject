using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using Business.ValidationRules;
using DAL.EntityFramework;
using DataEntities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [AllowAnonymous]
    //[Route("Member/[controller]/[action]")]
    public class ShopController : Controller
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = featureManager.TGetList();
            return View(values);
        }

        //[HttpPost]
        //public IActionResult Add(Feature2 p)
        //{
        //    featureManager.TAdd(p);
        //    return RedirectToAction("Add");
            
        //}
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Feature2 feature2)
        {
            BlogValidator validations = new BlogValidator();
            ValidationResult result = validations.Validate(feature2);
            //return RedirectToAction("Add");
            return View();
        }
    }
}

