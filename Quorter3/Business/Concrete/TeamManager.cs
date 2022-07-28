using System;
using System.Collections.Generic;
using Business.Abstract;
using DAL.Abstract;
using DataEntities.Concrete;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void TAdd(Team t)
        {
            _teamDal.Insert(t);
        }

        public void TDelete(Team t)
        {
            _teamDal.Delete(t);
        }

        public Team TGetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public List<Team> TGetList()
        {
            return _teamDal.GetList();
        }

        public void TUpdate(Team t)
        {
            throw new NotImplementedException();
        }
    }
}

