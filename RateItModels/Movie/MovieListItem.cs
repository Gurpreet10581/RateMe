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
        public decimal Duration { get; set; }
        public DateTime DateRelease { get; set; }
        public MovieGenre GenreOfMovie { get; set; }
        public MovieType TypeOfMovie { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
