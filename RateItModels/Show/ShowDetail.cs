using RateItData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Show
{
    public class ShowDetail
    {
        public int ReviewId { get; set; }
        [Required]
        public int ShowId { get; set; }
        public string ShowName { get; set; }
        public string DirectorName { get; set; }
        public decimal Duration { get; set; }
        public DateTime DateRelease { get; set; }
        public ShowGenre GenreOfShow { get; set; }
        public ShowType TypeOfShow { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
