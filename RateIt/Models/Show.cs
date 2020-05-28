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

    [Table("Show")]
    public partial class Show
    {
        public int ShowId { get; set; }

        public Guid OwnerId { get; set; }

        [Required]
        public string ShowName { get; set; }

        [Required]
        public string DirectorName { get; set; }

        public decimal Duration { get; set; }

        public DateTime DateRelease { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ShowGenre GenreOfShow { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
