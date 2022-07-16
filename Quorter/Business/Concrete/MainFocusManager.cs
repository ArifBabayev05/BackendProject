using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class MainFocusManager : IMainFocusService
    {
        IMainFocusDal _mainFocusDal;

        public MainFocusManager(IMainFocusDal mainFocusDal)
        {
            _mainFocusDal = mainFocusDal;
        }

        public void TAdd(MainFocus t)
        {
            _mainFocusDal.Insert(t);
        }

        public void TDelete(MainFocus t)
        {
            _mainFocusDal.Delete(t);
        }

        public MainFocus TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MainFocus> TGetList()
        {
            return _mainFocusDal.GetList();
        }

        public void TUpdate(MainFocus t)
        {
            throw new NotImplementedException();
        }
    }
}

