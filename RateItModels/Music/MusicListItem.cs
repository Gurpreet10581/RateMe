using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Music
{
    public class MusicListItem
    {
        public int ReviewId { get; set; }
        [Required]
        public int MusicId { get; set; }
        public string ArtistName { get; set; }
        [Display(Name = "Duration In Minutes")]
        public decimal Duration { get; set; }
        [Display(Name = "DateRelease")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateRelease { get; set; }
        public MusicGenre GenreOfMusic { get; set; }
        public MusicType TypeOfMusic { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
