using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
	public class SendManager : ISendService
	{
		ISendDal _sendDal;

        public SendManager(ISendDal sendDal)
        {
            _sendDal = sendDal;
        }

        public void TAdd(Send t)
        {
            _sendDal.Insert(t);
        }

        public void TDelete(Send t)
        {
            _sendDal.Delete(t);
        }

        public Send TGetById(int id)
        {
            return _sendDal.GetById(id);
        }

        public List<Send> TGetList()
        {
            return _sendDal.GetList();
        }

        public void TUpdate(Send t)
        {
            throw new NotImplementedException();
        }
    }
}

