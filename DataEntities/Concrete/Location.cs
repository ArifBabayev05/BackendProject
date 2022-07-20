using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        public string CityName { get; set; }
        public string Adress { get; set; }
        public string TelephoneNumber { get; set; }

    }
}

