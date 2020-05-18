using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Music
{
    public class MusicCreate
    {
        [Required]
        [MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        [MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string ArtistName { get; set; }
        [Required]
        [Range(1, 300, ErrorMessage = "Enter a valid Duration between 1 to 300 minutes")]
        public decimal Duration { get; set; }
        [Required]
        [Range(2000, 2020, ErrorMessage = "Enter a valid year")]
        public DateTime DateRelease { get; set; }
        [Required]
        public MusicGenre GenreOfMusic { get; set; }
        [Required]
        public MusicType TypeOfMusic { get; set; }
        public int ReviewId { get; set; }

    }
}
