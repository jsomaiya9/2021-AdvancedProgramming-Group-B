namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesrecommended : DbMigration
    {
        public override void Up()
        {
          
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AdvertModels",
                c => new
                    {
                        AdvertId = c.Int(nullable: false, identity: true),
                        LeagueId = c.Int(nullable: false),
                        Description = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.AdvertId);
            
            CreateIndex("dbo.AdvertModels", "LeagueId");
            AddForeignKey("dbo.AdvertModels", "LeagueId", "dbo.LeagueModels", "LeagueId", cascadeDelete: true);
        }
    }
}
