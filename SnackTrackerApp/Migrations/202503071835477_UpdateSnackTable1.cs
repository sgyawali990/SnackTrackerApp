namespace SnackTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSnackTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Snacks", "WarningLevel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Snacks", "WarningLevel");
        }
    }
}
