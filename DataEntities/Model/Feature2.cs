﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace DataEntities.Concrete
{
    public class Feature2
    {
        [Key]
        public int Id { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsSale { get; set; }
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public string CityName { get; set; }
        public string Description { get; set; }
        public int TotalRoomCount { get; set; }
        public int BathCount { get; set; }
        public int BedCount { get; set; }
        public int BuildYear { get; set; }
        public string MainPhoto { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        public int SalesManName { get; set; }


        public string FirstFloorImage { get; set; }
        public string FirstFloorDesc { get; set; }

        public string SecondFloorImage { get; set; }
        public string SecondFloorDesc { get; set; }

        public string ThirdFloorImage { get; set; }
        public string ThirdFloorDesc { get; set; }

        public string FourthFloorImage { get; set; }
        public string FourthFloorDesc { get; set; }

        public bool IsAllowedForPets { get; set; }

        public int LoungeArea { get; set; }
        
        public string OtherImage1 { get; set; }
        public string OtherImage2 { get; set; }
        public string OtherImage3 { get; set; }
        public string OtherImage4 { get; set; }

        
        public string SliderImage1 { get; set; }
        public string SliderImage2 { get; set; }
        public string SliderImage3 { get; set; }
        public string SliderImage4 { get; set; }

        public int Price { get; set; }

        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorDesc { get; set; }

        public List<CommentModel> CommentModels { get; set; }



    }
}

