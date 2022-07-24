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
        //SendManager manager = new SendManager(new EfSendDal());
        //[HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(Email email)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add("arifrb@code.edu.az");
            mailMessage.From = new MailAddress("arifrb@code.edu.az");
            mailMessage.Subject = email.Subject;
            return View();
        }
        


    } 
}

