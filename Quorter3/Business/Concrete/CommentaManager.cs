using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class CommentaManager : ICommentaService
    {

        ICommentaDal _commentaDal;
        public CommentaManager(ICommentaDal commentaDal)
        {
            _commentaDal = commentaDal;
        }
        public void TAdd(CommentModel t)
        {
            _commentaDal.Insert(t);
        }

        public void TDelete(CommentModel t)
        {
            _commentaDal.Delete(t);
        }

        public CommentModel TGetById(int id)
        {
            return _commentaDal.GetById(id);
        }

        public List<CommentModel> TGetList()
        {
            return _commentaDal.GetList();
        }

        public List<CommentModel> TGetShop(int id)
        {
            return _commentaDal.GetListByFilter(x => x.Feature2Id == id);
        }

        public void TUpdate(CommentModel t)
        {
            throw new NotImplementedException();
        }
    }
}

