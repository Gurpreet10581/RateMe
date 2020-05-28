namespace RateIt.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieDataModel : DbContext
    {
        public MovieDataModel()
            : base("name=MovieDataModel")
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
