namespace RateIt.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using RateItData;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        public int MovieId { get; set; }

        public Guid OwnerId { get; set; }

        [Required]
        public string MovieName { get; set; }

        [Required]
        public string DirectorName { get; set; }

        public decimal Duration { get; set; }

        public DateTime DateRelease { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]

        public MovieGenre GenreOfMovie { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
