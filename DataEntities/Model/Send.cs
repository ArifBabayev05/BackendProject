﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Send
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string MessageUser { get; set; }

    }
}

