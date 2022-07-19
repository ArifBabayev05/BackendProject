using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Counter
    {
        [Key]
        public int Id { get; set; }

        public int Count { get; set; }

        public string Name { get; set; }

        public string IconUrl { get; set; }

    }
}

