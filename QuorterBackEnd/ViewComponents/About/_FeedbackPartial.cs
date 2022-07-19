using System;
using Business.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace QuorterBackEnd.ViewComponents.About
{
    public class _FeedbackPartial : ViewComponent
    {
        CommentaManager commentaManager = new CommentaManager(new EfCommentaDal());
        public IViewComponentResult Invoke(int id)
        {
            
            var values = commentaManager.TGetList();
            return View(values);
        }
        
    }
}

