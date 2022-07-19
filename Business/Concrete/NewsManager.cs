using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class NewsManager : INewsService
    {
        INewsDal _newsManager;

        public NewsManager(INewsDal newsManager)
        {
            _newsManager = newsManager;
        }

        public void TAdd(News t)
        {
            _newsManager.Insert(t);
        }

        public void TDelete(News t)
        {
            _newsManager.Delete(t);
        }

        public News TGetById(int id)
        {
            return _newsManager.GetById(id);
        }

        public List<News> TGetList()
        {
            return _newsManager.GetList();
        }

        public void TUpdate(News t)
        {
            throw new NotImplementedException();
        }
    }
}

