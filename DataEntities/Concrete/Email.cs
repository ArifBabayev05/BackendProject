﻿using System;
namespace DataEntities.Concrete
{
    public class Email
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string Subject{ get; set; }
        public string Body { get; set; }
    }
}

