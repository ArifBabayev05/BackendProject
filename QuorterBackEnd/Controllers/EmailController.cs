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
        EmailManager manager = new EmailManager(new EfEmailDal());
        //[HttpGet]
        public IActionResult Index()
        {
            var values = manager.TGetList();
            return View(values);
        }

        //[HttpPost]
        //public IActionResult Index(Email email)
        //{
        //    string to = email.To;
        //    string subject = email.Subject;
        //    string body = email.Body;
        //    MailMessage mm = new MailMessage();
        //    mm.To.Add(to);
        //    mm.Subject = subject;
        //    mm.Body = body;
        //    mm.From = new MailAddress("arif.babayev.2005@gmail.com");
        //    mm.IsBodyHtml = false;
        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        //    smtp.Port = 587;
        //    smtp.UseDefaultCredentials = false;
        //    smtp.EnableSsl = true;
        //    smtp.Credentials = new System.Net.NetworkCredential("arif.babayev.2005@gmail.com", "password");
        //    smtp.Send(mm);
        //    ViewBag.message = "Thank You For Subscribing";
        //    return View();
        //}
    } 
}

