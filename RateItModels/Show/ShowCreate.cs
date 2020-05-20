using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Show
{
    public class ShowCreate
    {
        [Required]
        [MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        [MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string ShowName { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        [MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string DirectorName { get; set; }
        [Required]
        [Display(Name = "Duration In Minutes")]
        public decimal Duration { get; set; }
        [Required]
        [Display(Name = "DateRelease")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateRelease { get; set; }
        [Required]
        public ShowGenre GenreOfShow { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        //public int ReviewId { get; set; }
    }
}
