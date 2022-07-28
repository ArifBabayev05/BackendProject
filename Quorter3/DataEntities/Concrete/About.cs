using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment{ get; set; }
        public string Adds { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Add4 { get; set; }

        public string Image{ get; set; }


    }
}

