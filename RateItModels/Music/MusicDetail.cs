using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Music
{
    public class MusicDetail
    {
        public int ReviewId { get; set; }
        [Required]
        public int MusicId { get; set; }
        public string ArtistName { get; set; }
        public decimal Duration { get; set; }
        public DateTime DateRelease { get; set; }
        public MusicGenre GenreOfMusic { get; set; }
        public MusicType TypeOfMusic { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
