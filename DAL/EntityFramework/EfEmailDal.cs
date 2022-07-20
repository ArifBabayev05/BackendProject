using System;
using DAL.Abstract;
using DAL.Migrations;
using DAL.Repository;
using DataEntities.Concrete;

namespace DAL.EntityFramework
{
    public class EfEmailDal : GenericRepository<Email>, IEmailDal
    {
        public EfEmailDal()
        {
        }
    }
}

