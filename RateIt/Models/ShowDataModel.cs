namespace RateIt.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShowDataModel : DbContext
    {
        public ShowDataModel()
            : base("name=ShowDataModel")
        {
        }

        public virtual DbSet<Show> Shows { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
