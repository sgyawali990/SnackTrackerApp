namespace SnackTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSnackDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Snacks", "WarningThreshold", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Snacks", "WarningThreshold");
        }
    }
}
