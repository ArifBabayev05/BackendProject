using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class EmailManager : IEmailService
    {
        IEmailDal _emailDal;

        public EmailManager(IEmailDal emailDal)
        {
            _emailDal = emailDal;
        }

        public void TAdd(Email t)
        {
            _emailDal.Insert(t);
        }

        public void TDelete(Email t)
        {
            _emailDal.Delete(t);
        }

        public Email TGetById(int id)
        {
            return _emailDal.GetById(id);
        }

        public List<Email> TGetList()
        {
            return _emailDal.GetList();
        }

        public void TUpdate(Email t)
        {
            throw new NotImplementedException();
        }
    }
}

