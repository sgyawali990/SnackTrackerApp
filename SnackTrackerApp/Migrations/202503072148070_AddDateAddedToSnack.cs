namespace SnackTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateAddedToSnack : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Snacks", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Snacks", "DateAdded");
        }
    }
}
