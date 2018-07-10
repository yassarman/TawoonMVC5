namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsInHoushToBuildingTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "isInHoush", c => c.Boolean(nullable: false,defaultValue:false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Buildings", "isInHoush");
        }
    }
}
