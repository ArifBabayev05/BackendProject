﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.Areas.Member.Controllers
{
    [Area("Member")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

