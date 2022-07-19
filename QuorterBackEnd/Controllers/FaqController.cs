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
    public class FaqController : Controller
    {
        FaqManager faqManager = new FaqManager(new EfFaqDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = faqManager.TGetList();
            return View(values);
        }
    }
}

