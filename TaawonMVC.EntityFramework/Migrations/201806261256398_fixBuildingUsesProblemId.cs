namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixBuildingUsesProblemId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BuildingUses", "UsedFor", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BuildingUses", "UsedFor", c => c.String());
        }
    }
}
