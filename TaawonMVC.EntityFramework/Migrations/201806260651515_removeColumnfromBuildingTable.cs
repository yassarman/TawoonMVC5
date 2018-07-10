namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeColumnfromBuildingTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Buildings", "isInHoush");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buildings", "isInHoush", c => c.Boolean(nullable: false));
        }
    }
}
