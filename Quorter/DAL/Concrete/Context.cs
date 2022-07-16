using System;
using DataEntities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=QuorterDataBase;User Id=sa;Password=MyPass@word");
        }

        public DbSet<About> Abouts{ get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Newsletter> Newsletters{ get; set; }
        public DbSet<MainFocus> MainFocuses{ get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Team> Teams{ get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        

    }
}

