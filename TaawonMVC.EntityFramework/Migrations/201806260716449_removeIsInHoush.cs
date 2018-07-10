namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeIsInHoush : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Buildings", "buildingName", c => c.String(nullable: false));
            DropColumn("dbo.Buildings", "isInHoush");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buildings", "isInHoush", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Buildings", "buildingName", c => c.String());
        }
    }
}
