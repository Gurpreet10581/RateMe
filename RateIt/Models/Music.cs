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

    [Table("Music")]
    public partial class Music
    {
        public int MusicId { get; set; }

        public Guid OwnerId { get; set; }

        [Required]
        public string ArtistName { get; set; }

        public decimal Duration { get; set; }

        public DateTime DateRelease { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public MusicGenre GenreOfMusic { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public MusicType TypeOfMusic { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
