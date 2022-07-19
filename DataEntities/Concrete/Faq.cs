using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TelephoneNumber { get; set; }
        public int Counter { get; set; }

    }
}

