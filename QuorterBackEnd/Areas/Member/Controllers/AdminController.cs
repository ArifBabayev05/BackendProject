﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuorterBackEnd.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]

    public class AdminController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppRole appRole = new AppRole()
                {
                    Name = model.name
                };

                var result = await _roleManager.CreateAsync(appRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index" , "Admin");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            RoleUpdateViewModel roleUpdateViewModel = new RoleUpdateViewModel()
            {
                Id = values.Id,
                name = values.Name
            };
                return View(roleUpdateViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Update(RoleUpdateViewModel model)
        {
            var values = _roleManager.Roles.Where(x => x.Id == model.Id).FirstOrDefault();

            values.Name = model.name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Admin");
            }
            return View(model);


        }
        public async Task<IActionResult> Delete(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _roleManager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Admin");

            }
            return View();
        }

        public IActionResult UserRoleList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
    }
}
