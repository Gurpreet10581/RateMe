using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItModels.Review
{
    public class ReviewCreate
    {
        [Required]
        [MaxLength(3000, ErrorMessage = "Maximum character lenght required is 3000 ")]
        [MinLength(10, ErrorMessage = "Minimum character lenght required is 10 ")]
        public string Content { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Enter a rating on a scale of 1-5")]
        public int Rating { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }


    }
}
