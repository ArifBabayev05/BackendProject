using System;
using System.ComponentModel.DataAnnotations;

namespace QuorterBackEnd.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Please Enter Your User Name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]
        public string password { get; set; }
    }
}

