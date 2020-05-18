using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Music
{
    public class MusicEdit
    {
        public int ReviewId { get; set; }
        [Required]
        public int MusicId { get; set; }
        [MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        [MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string ArtistName { get; set; }
        [Range(1, 300, ErrorMessage = "Enter a valid Duration between 1 to 300 minutes")]
        public decimal Duration { get; set; }
        [Range(2000, 2020, ErrorMessage = "Enter a valid year")]
        public DateTime DateRelease { get; set; }
        public MusicGenre GenreOfMusic { get; set; }
        public MusicType TypeOfMusic { get; set; }

    }
}
