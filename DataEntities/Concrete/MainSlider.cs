using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class MainSlider
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }



    }
}

