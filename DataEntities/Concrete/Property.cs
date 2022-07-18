using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public int PropertyCount { get; set; }
        public bool IsDeleted { get; set; }
    }
}

