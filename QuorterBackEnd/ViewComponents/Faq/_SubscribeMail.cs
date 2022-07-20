﻿using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Faq
{
    public class _SubscribeMail : ViewComponent
    {
        EmailManager manager = new EmailManager(new EfEmailDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
    }
}

