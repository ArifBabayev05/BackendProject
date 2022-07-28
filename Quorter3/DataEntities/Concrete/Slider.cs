using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Slider
    {
        [Key]
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }

    }
}

