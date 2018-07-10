namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsInHoushToTableBuildings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "isInHoush", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Buildings", "buildingName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Buildings", "buildingName", c => c.String(nullable: false));
            DropColumn("dbo.Buildings", "isInHoush");
        }
    }
}
