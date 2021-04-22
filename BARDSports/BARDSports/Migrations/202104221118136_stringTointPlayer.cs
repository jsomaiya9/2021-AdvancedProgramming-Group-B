namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringTointPlayer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PlayerModels", "Goals", c => c.Int(nullable: false));
            AlterColumn("dbo.PlayerModels", "Assists", c => c.Int(nullable: false));
            AlterColumn("dbo.PlayerModels", "YellowCards", c => c.Int(nullable: false));
            AlterColumn("dbo.PlayerModels", "RedCards", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PlayerModels", "RedCards", c => c.String());
            AlterColumn("dbo.PlayerModels", "YellowCards", c => c.String());
            AlterColumn("dbo.PlayerModels", "Assists", c => c.String());
            AlterColumn("dbo.PlayerModels", "Goals", c => c.String());
        }
    }
}
