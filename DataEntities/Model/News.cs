using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content1 { get; set; }
        public string BannerImage { get; set; }
        public string MainImage { get; set; }

        public string Title1 { get; set; }
        public string Text1 { get; set; }

        public string Title2 { get; set; }
        public string Text2 { get; set; }

        public string Title3 { get; set; }
        public string Text3 { get; set; }

        public string Quote { get; set; }
        public string Text4 { get; set; }

        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Title4 { get; set; }

        public string AuthorDesc { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorName { get; set; }

        public List<CommentModel> CommentModels { get; set; }

        public string MainTitle { get; set; }
        public string LastContext { get; set; }


    }
}

