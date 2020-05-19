namespace RateItData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedMovieproperties : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movie", "TypeOfMovie");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "TypeOfMovie", c => c.Int(nullable: false));
        }
    }
}
