using System;
using System.ComponentModel.DataAnnotations;

namespace QuorterBackEnd.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Please Enter Name  ")]
        public string name { get; set; }


    }
}

