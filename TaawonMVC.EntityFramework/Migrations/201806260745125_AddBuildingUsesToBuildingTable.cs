namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuildingUsesToBuildingTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "buildingUsesID", c => c.Int(nullable: false));
            CreateIndex("dbo.Buildings", "buildingUsesID");
            AddForeignKey("dbo.Buildings", "buildingUsesID", "dbo.BuildingUses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buildings", "buildingUsesID", "dbo.BuildingUses");
            DropIndex("dbo.Buildings", new[] { "buildingUsesID" });
            DropColumn("dbo.Buildings", "buildingUsesID");
        }
    }
}
