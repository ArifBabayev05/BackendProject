using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public bool  IsDeleted { get; set; }
        public string MapLocation { get; set; }

    }
}

