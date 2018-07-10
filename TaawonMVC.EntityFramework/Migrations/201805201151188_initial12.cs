namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial12 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Buildings", "neighborhoodID");
            CreateIndex("dbo.Buildings", "buildingTypeID");
            AddForeignKey("dbo.Buildings", "buildingTypeID", "dbo.BuildingTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Buildings", "neighborhoodID", "dbo.Neighborhoods", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buildings", "neighborhoodID", "dbo.Neighborhoods");
            DropForeignKey("dbo.Buildings", "buildingTypeID", "dbo.BuildingTypes");
            DropIndex("dbo.Buildings", new[] { "buildingTypeID" });
            DropIndex("dbo.Buildings", new[] { "neighborhoodID" });
        }
    }
}
