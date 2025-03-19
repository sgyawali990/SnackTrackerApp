namespace SnackTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Snacks", "DailyConsumption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Snacks", "DailyConsumption", c => c.Int(nullable: false));
        }
    }
}
