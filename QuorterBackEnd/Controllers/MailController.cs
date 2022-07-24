using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Controllers
{
    public class MailController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendEmail email)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add("arifrb@code.edu.az");
            mailMessage.From = new MailAddress("arifrb@code.edu.az");
            mailMessage.Subject ="You Have A Message:"+ email.Title;
            mailMessage.Body = "Dear Admin,You Have Message From:" + User.Identity.Name + ", The Message Is:" + email.Text;
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("arifrb@code.edu.az","Idontremember");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);
                TempData["Message"] = "Mail Succesfully Sended.";

            }
            catch (Exception ex)
            {
                TempData["Message"] = "Mail Can Not Send. Error Message" + ex.Message;
            }
            return View();
        }
    }
}

