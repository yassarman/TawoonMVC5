namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeBuildingUsesIdFromBuildings : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Buildings", "buildingUsesID", "dbo.BuildingUses");
            DropIndex("dbo.Buildings", new[] { "buildingUsesID" });
            DropColumn("dbo.Buildings", "buildingUsesID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buildings", "buildingUsesID", c => c.Int(nullable: false));
            CreateIndex("dbo.Buildings", "buildingUsesID");
            AddForeignKey("dbo.Buildings", "buildingUsesID", "dbo.BuildingUses", "Id", cascadeDelete: true);
        }
    }
}
