using System;
using Microsoft.AspNetCore.Http;

namespace QuorterBackEnd.Areas.Member.Models
{
    public class UserEditNewModel
    {
        public string name { get; set; }

        public string surname { get; set; }

        public string password { get; set; }

        public string confirmPassword { get; set; }

        public string mail { get; set; }

        public string imageUrl { get; set; }

        public string phonenumber { get; set; }

        public IFormFile Image { get; set; }




    }
}

