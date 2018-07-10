namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewColumnsToBuildingsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "isInHoush", c => c.Boolean(nullable: false));
            AddColumn("dbo.Buildings", "buildingName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Buildings", "buildingName");
            DropColumn("dbo.Buildings", "isInHoush");
        }
    }
}
