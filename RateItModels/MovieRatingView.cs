using RateItModels.Movie;
using RateItModels.Review;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels
{
    public class MovieRatingView
    {
        [Required]
        public int MovieId { get; set; }

        [Display(Name = "Min, Max, & Avg. Rating ***** ")]
        public string[,] MinMaxAvg { get; set; }

        public IEnumerable<int> Ratings { get; set; }
    }
}
