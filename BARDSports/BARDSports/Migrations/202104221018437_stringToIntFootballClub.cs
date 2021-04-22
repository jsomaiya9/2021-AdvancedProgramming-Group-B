namespace BARDSports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FootballClubModels", "Goals", c => c.Int(nullable: false));
            AlterColumn("dbo.FootballClubModels", "Passes", c => c.Int(nullable: false));
            AlterColumn("dbo.FootballClubModels", "Cleansheets", c => c.Int(nullable: false));
            AlterColumn("dbo.FootballClubModels", "Wins", c => c.Int(nullable: false));
            AlterColumn("dbo.FootballClubModels", "Draws", c => c.Int(nullable: false));
            AlterColumn("dbo.FootballClubModels", "Lost", c => c.Int(nullable: false));
            AlterColumn("dbo.FootballClubModels", "Points", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FootballClubModels", "Points", c => c.String());
            AlterColumn("dbo.FootballClubModels", "Lost", c => c.String());
            AlterColumn("dbo.FootballClubModels", "Draws", c => c.String());
            AlterColumn("dbo.FootballClubModels", "Wins", c => c.String());
            AlterColumn("dbo.FootballClubModels", "Cleansheets", c => c.String());
            AlterColumn("dbo.FootballClubModels", "Passes", c => c.String());
            AlterColumn("dbo.FootballClubModels", "Goals", c => c.String());
        }
    }
}
