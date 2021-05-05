namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringtointrating : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CommentsModels", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CommentsModels", "Rating", c => c.String());
        }
    }
}
