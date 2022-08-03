using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public int PropertyCount { get; set; }
        public bool IsDeleted { get; set; }

        public string Description { get; set; }

        public string BannerImage { get; set; }
        public string ExampleImage1 { get; set; }
        public string ExampleImage2 { get; set; }
        public string ExampleImage3 { get; set; }

        public string SliderImage1 { get; set; }
        public string SliderImage2 { get; set; }
        public string SliderImage3 { get; set; }
        public string SliderImage4 { get; set; }

        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorDesc { get; set; }

        public List<CommentModel> CommentModels { get; set; }
    }
}

