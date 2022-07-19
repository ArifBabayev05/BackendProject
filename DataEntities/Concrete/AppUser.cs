using System;
using Microsoft.AspNetCore.Identity;

namespace DataEntities.Concrete
{
   
        public class AppUser : IdentityUser<int>
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Gender { get; set; }
            public string ImageUrl { get; set; }


    }
    
}

