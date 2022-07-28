using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.Message
{
    public class _MessageList : ViewComponent
    {
        CommentaManager teamManager = new CommentaManager(new EfCommentaDal());
        public IViewComponentResult Invoke()
        {
            var values = teamManager.TGetList();
            return View(values);
        }
    }
}

