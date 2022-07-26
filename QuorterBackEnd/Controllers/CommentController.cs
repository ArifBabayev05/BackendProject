﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DAL.EntityFramework;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuorterBackEnd.Controllers
{
    public class CommentController : Controller
    {
        CommentaManager commentaManager = new CommentaManager(new EfCommentaDal());
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(CommentModel p,int id)
        {
            //ViewBag.i = p.CommentId;            

            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
            p.CommentState = true;

            commentaManager.TAdd(p);
            return RedirectToAction("Index", "Shop", new { id= commentaManager.TGetById(id)});
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var element = commentaManager.TGetById(id);
            commentaManager.TDelete(element);

            return RedirectToAction("Index", "Member");

        }
    }
}


