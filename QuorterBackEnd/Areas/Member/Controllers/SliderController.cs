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
using QuorterBackEnd.Areas.Member.Models;
using QuorterBackEnd.Models;
using X.PagedList;
using X.PagedList.Mvc;
namespace QuorterBackEnd.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [Authorize(Roles = "Admin,SuperAdmin,Manager")]
    public class SliderController : Controller
    {
        
        SliderManager featureManager = new SliderManager(new EfSliderDal());
        // GET: /<controller>/
        public IActionResult Index(int page = 1)
        {
            //var values = featureManager.TGetList();
            var values = featureManager.TGetList().ToPagedList(page, 2);

            return View(values);
        }
        

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(MainSlider feature2, SendEmail email, AppUser appUser)
        {
            if (feature2.MainPhoto == null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(feature2.MainPhoto.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/assets/uploads/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await feature2.MainPhoto.CopyToAsync(stream);

                feature2.Image = imageName;
            }
            string link = Url.Action("Index", "Slider");

            //MailMessage mailMessage = new MailMessage();
            //mailMessage.To.Add("arifrb@code.edu.az");
            //mailMessage.From = new MailAddress("arifrb@code.edu.az");
            //mailMessage.Subject = "Quorter Product";
            //mailMessage.Body = "Dear" + User.Identity.Name + $", We Have New Special Product For You. Dont Forget Visit Us";
            //mailMessage.IsBodyHtml = true;



            //SmtpClient smtpClient = new SmtpClient();
            //smtpClient.Credentials = new NetworkCredential("arifrb@code.edu.az", "Idontremember");
            //smtpClient.Port = 587;
            //smtpClient.Host = "smtp.gmail.com";
            //smtpClient.EnableSsl = true;

            //try
            //{
            //    smtpClient.Send(mailMessage);
            //    TempData["Message"] = "Mail Succesfully Sended.";

            //}
            //catch (Exception ex)
            //{
            //    TempData["Message"] = "Mail Can Not Send. Error Message" + ex.Message;
            //}

            featureManager.TAdd(feature2);
            return RedirectToAction("Index", "Slider");


        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var element = featureManager.TGetById(id);
            featureManager.TDelete(element);

            return RedirectToAction("Index", "Slider");

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = featureManager.TGetById(id);
            featureManager.TDelete(value);

            return View(value);
        }
        [HttpPost]
        public IActionResult Update(MainSlider feature2)
        {
            //if (feature2.Image == null)
            //{
            //    var resource = Directory.GetCurrentDirectory();
            //    var extension = Path.GetExtension(feature2.MainPhoto.FileName);
            //    var imageName = Guid.NewGuid() + extension;
            //    var saveLocation = resource + "/wwwroot/assets/uploads/" + imageName;
            //    var stream = new FileStream(saveLocation, FileMode.Create);
            //    await feature2.MainPhoto.CopyToAsync(stream);

            //    feature2.Image = imageName;
            //}
            featureManager.TUpdate(feature2);
            return RedirectToAction("Index", "Slider");


        }
    }
}

