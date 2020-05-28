namespace RateIt.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MusicDataModel : DbContext
    {
        public MusicDataModel()
            : base("name=MusicDataModel")
        {
        }

        public virtual DbSet<Music> Musics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
