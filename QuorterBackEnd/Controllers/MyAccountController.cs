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
    public class MyAccountController : Controller
    {
        MyAccountManager propertyManager = new MyAccountManager(new EfMyAccountDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = propertyManager.TGetList();
            return View(values);
        }
    }
}

