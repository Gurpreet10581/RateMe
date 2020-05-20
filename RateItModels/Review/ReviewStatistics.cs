using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Review
{
    public class ReviewStatistics
    {
        [Required]
        public int ReviewId { get; set; }

        [Display(Name = "Min, Max, & Avg. Rating ***** ")]
        public string[,] MinMaxAvg { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Display(Name = "Rating ***** ")]
        public List<int> Ratings { get; set; }

        [Display(Name = "Movie ID")]
        public int? MovieId { get; set; }

        [Display(Name = "Music ID")]
        public int? MusicId { get; set; }

        [Display(Name = "Show ID")]
        public int? ShowId { get; set; }
    }

}
