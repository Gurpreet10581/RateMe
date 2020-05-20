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
        public string[,] MinMaxAvg { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public int? MovieId { get; set; }
        public int? ShowId { get; set; }
        public int? MusicId { get; set; }
        public List<int> Ratings { get; set; }
    }
}
