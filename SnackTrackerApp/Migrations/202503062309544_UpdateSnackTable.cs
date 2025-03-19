﻿namespace SnackTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSnackTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Snacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                        DailyConsumption = c.Int(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Snacks");
        }
    }
}
