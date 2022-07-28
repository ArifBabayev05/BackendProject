using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedinUrl { get; set; }

        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }

        public int ExperienceYear { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }

    }
}

