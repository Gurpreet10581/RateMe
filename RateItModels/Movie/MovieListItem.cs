using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Movie
{
    public class MovieListItem
    {
        public int ReviewId { get; set; }
        [Required]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        [Display(Name = "Duration In Minutes")]
        public decimal Duration { get; set; }
        [Display(Name = "DateRelease")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateRelease { get; set; }
        public MovieGenre GenreOfMovie { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
