using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace RateItData
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        //[MaxLength(3000, ErrorMessage = "Maximum character lenght required is 3000 ")]
        //[MinLength(10, ErrorMessage = "Minimum character lenght required is 10 ")]
        public string Content { get; set; }
        [Required]
        //[Range(1, 5, ErrorMessage = "Enter a rating on a scale of 1-5")]
        public int Rating { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
