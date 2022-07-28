using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class MyAccountManager : IMyAccountService
    {
        IMyAccountDal _myAccountDal;

        public MyAccountManager(IMyAccountDal myAccountDal)
        {
            _myAccountDal = myAccountDal;
        }

        public void TAdd(AppUser t)
        {
            _myAccountDal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
            _myAccountDal.Delete(t);
        }

        public AppUser TGetById(int id)
        {
            return _myAccountDal.GetById(id);
        }

        public List<AppUser> TGetList()
        {
            return _myAccountDal.GetList();
        }

        public void TUpdate(AppUser t)
        {
            _myAccountDal.Update(t);
        }
    }
}

