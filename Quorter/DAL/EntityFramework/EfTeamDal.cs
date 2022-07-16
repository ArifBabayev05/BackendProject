using System;
using DAL.Abstract;
using DAL.Repository;
using DataEntities.Concrete;

namespace DAL.EntityFramework
{
    public class EfTeamDal : GenericRepository<Team>, ITeamDal
    {


        
    }
}

