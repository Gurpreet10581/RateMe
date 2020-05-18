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
    public enum MusicGenre { Alternative = 1, African, American, Bollywood, Comedy, Classical, Country, Dance, Electronic, Holiday, Jazz, Latino, Opera, Other, Pop, Reggae, Rock, Rap, Worl }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MusicType { Single = 1, Album }
    public class Music
    {
        [Key]
        public int MusicId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        //[MaxLength(300, ErrorMessage = "Maximum character lenght required is 300 ")]
        //[MinLength(1, ErrorMessage = "Minimum character lenght required is 1 ")]
        public string ArtistName { get; set; }
        [Required]
        //[Range(1, 300, ErrorMessage = "Enter a valid Duration between 1 to 300 minutes")]
        public decimal Duration { get; set; }
        [Required]
        //[Range(2000, 2020, ErrorMessage = "Enter a valid year")]
        public DateTime DateRelease { get; set; }
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public MusicGenre GenreOfMusic { get; set; }
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public MusicType TypeOfMusic { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
        public int ReviewId { get; set; }
        [ForeignKey(nameof(ReviewId))]
        public virtual Review Review { get; set; }
    }
}
