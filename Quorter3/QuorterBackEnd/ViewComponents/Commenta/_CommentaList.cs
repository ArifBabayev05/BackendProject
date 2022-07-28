using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Commenta
{
    public class _CommentaList : ViewComponent
    {
        CommentaManager commentaManager = new CommentaManager(new EfCommentaDal());
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.i = id;
            var values = commentaManager.TGetShop(id);
            return View(values );
        }
    }
}

