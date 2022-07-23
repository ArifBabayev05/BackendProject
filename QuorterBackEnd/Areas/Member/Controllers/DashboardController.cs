using System;
using System.Threading.Tasks;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Admin,SuperAdmin,Manager")]

    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " " + values.Surname;
            ViewBag.userImage = values.ImageUrl;
            ViewBag.telNum = values.PhoneNumber;
            return View();
        }
    }
}

