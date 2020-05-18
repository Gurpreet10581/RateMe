using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItData
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MovieGenre { Aventure = 1, Actrion, Animation, Crime, Comedy, Drama, Fantasy, Horror, Musical, Thriller, War }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MovieType { Hollywood = 1, Bollywood, Others }

    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        //[MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        //[MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string MovieName { get; set; }
        [Required]
        //[MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        //[MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string DirectorName { get; set; }
        [Required]
        //[Range(1, 300, ErrorMessage = "Enter a valid Duration between 1 to 300 minutes")]
        public decimal Duration { get; set; }
        [Required]
        //[Range(2000, 2020, ErrorMessage = "Enter a valid year")]
        public DateTime DateRelease { get; set; }
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public MovieGenre GenreOfMovie { get; set; }
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public MovieType TypeOfMovie { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
        public int ReviewId { get; set; }
        [ForeignKey(nameof(ReviewId))]
        public virtual Review Review { get; set; }

    }
}
