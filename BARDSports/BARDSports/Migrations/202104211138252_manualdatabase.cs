namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manualdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerFansModels",
                c => new
                {
                    PlayerFansId = c.Int(nullable: false, identity: true),
                    PlayerId = c.Int(nullable: false),
                    Id = c.String(maxLength: 128),
                })
                .PrimaryKey(t => t.PlayerFansId)
                .ForeignKey("dbo.PlayerModels", t => t.PlayerId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.PlayerId)
                .Index(t => t.Id);

            DropForeignKey("dbo.CommentsModels", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.CommentsModels", new[] { "Id" });                   
            AlterColumn("dbo.CommentsModels", "Id", c => c.String());
           
        }
        
        public override void Down()
        {
           AlterColumn("dbo.PlayerFansModels", "Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.CommentsModels", "Id", c => c.String(maxLength: 128));
           CreateIndex("dbo.PlayerFansModels", "Id");
            CreateIndex("dbo.CommentsModels", "Id");
            AddForeignKey("dbo.PlayerFansModels", "Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.CommentsModels", "Id", "dbo.AspNetUsers", "Id");
        }
    }
}
