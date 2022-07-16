using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
            public string Mail { get; set; }
        
    }
}

