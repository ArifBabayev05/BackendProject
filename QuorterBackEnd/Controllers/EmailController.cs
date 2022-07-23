using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Business.Concrete;
using DAL.EntityFramework;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Controllers
{
    public class EmailController : Controller
    {
        SendManager manager = new SendManager(new EfSendDal());
        //[HttpGet]
        public IActionResult Index()
        {
            var values = manager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Send(Send email)
        {
            manager.TAdd(email);
            return RedirectToAction("Index", "Contact");
        }


    } 
}

