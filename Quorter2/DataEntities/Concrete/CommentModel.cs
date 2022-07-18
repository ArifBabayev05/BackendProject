using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class CommentModel
    {
       [Key]

        public int CommentId { get; set; }
        public string CommentUser { get; set; }
        public string CommentContent  { get; set; }
        public bool CommentState { get; set; }
        public DateTime CommentDate { get; set; }

        public int Feature2Id { get; set; }
        public Feature2 Feature2 { get; set; }


    }
}

