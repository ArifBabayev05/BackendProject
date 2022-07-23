using System;
using DataEntities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=QuorterDatas;User Id=sa;Password=MyPass@word");
        }

        public DbSet<About> Abouts{ get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature2> Features { get; set; }
        public DbSet<Newsletter> Newsletters{ get; set; }
        public DbSet<MainFocus> MainFocuses{ get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Team> Teams{ get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<CommentModel> CommentModels { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<News> News{ get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Location2> Location2s { get; set; }
        public DbSet<Map> Maps{ get; set; }
        public DbSet<MainSlider> MainSliders { get; set; }
        public DbSet<Email> Emails { get; set; }

        public DbSet<Send> Sends { get; set; }


    }
}

