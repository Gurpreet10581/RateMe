using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Show
{
    public class ShowListItem
    {
        //public int ReviewId { get; set; }
        [Required]
        public int ShowId { get; set; }
        public string ShowName { get; set; }
        public string DirectorName { get; set; }

        [Display(Name = "Duration In Minutes")]
        public decimal Duration { get; set; }

        [Display(Name = "DateRelease")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateRelease { get; set; }
        public ShowGenre GenreOfShow { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
