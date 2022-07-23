using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuorterBackEnd.Areas.Member.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [Authorize(Roles = "Admin,SuperAdmin,Manager")]

    public class ProfileController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager )
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditNewModel userEditNewModel = new UserEditNewModel();
            userEditNewModel.name = values.Name;
            userEditNewModel.surname = values.Surname;
            userEditNewModel.mail = values.Email;
            userEditNewModel.phonenumber = values.PhoneNumber;
            return View(userEditNewModel );
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditNewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/assets/uploads/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);

                user.ImageUrl = imageName;
             }

            user.Name = p.name;
            user.Surname = p.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}

