using System;
using System.ComponentModel.DataAnnotations;

namespace QuorterBackEnd.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your SurName")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please Enter Your UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Your ConfirmPassword"),Compare("Password", ErrorMessage = "Confirm Password Does not Match with Password")]
        public string ConfirmPassword { get; set; }
    }
}

