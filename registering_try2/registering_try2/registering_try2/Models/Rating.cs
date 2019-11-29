using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registering_try2.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public byte RatingGrade { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public RatingCategory RatingCategory { get; set; }
        public int RatingCategoryId { get; set; }

    }
}
