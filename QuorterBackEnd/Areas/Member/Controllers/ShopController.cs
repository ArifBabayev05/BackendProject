using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using Business.ValidationRules;
using DAL.Concrete;
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
    [Authorize(Roles = "Admin,SuperAdmin")]
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

    
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Feature2 feature2)
        {
            if (feature2.MainPhoto == null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(feature2.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/assets/uploads/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await feature2.Image.CopyToAsync(stream);

                feature2.MainPhoto= imageName;
            }

            featureManager.TAdd(feature2);
            return RedirectToAction("Index", "Shop");

            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var element = featureManager.TGetById(id);
            featureManager.TDelete(element);
            
            return RedirectToAction("Index", "Shop");

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = featureManager.TGetById(id);
            featureManager.TDelete(value);

            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Feature2 feature2)
        {

            featureManager.TUpdate(feature2);
            return RedirectToAction("Index", "Shop");


        }


    }
}

