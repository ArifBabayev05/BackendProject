using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        public async Task<IActionResult> Add(Feature2 feature2,SendEmail email, AppUser appUser)
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
            string link = Url.Action("Index", "Shop");

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add("arifrb@code.edu.az");
            mailMessage.From = new MailAddress("arifrb@code.edu.az");
            mailMessage.Subject = "Quorter Product";
            mailMessage.Body = "Dear" + User.Identity.Name + $", We Have New Special Product For You. Dont Forget Visit Us" ;
            mailMessage.IsBodyHtml = true;

            //if (file != null)
            //{
            //    mailMessage.Attachments.Add(new Attachment(file.InputStream));
            //};


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("arifrb@code.edu.az", "Idontremember");
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

