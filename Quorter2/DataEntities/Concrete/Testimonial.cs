using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Testimonial
    {
        [Key] 
        public int Id { get; set; }
        public string Client { get; set; }
        public string ClientImage { get; set; }
        public string PositionName { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }

    }
}

