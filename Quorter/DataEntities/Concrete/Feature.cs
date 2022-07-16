using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Feature
    {
        [Key]
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
         
    }
}

