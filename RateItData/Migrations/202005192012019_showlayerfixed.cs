namespace RateItData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class showlayerfixed : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Show", "TypeOfShow");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Show", "TypeOfShow", c => c.Int(nullable: false));
        }
    }
}
