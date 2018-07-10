namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial15 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Buildings");
            AlterColumn("dbo.Buildings", "buildingID", c => c.Int(nullable: false));
            AlterColumn("dbo.Buildings", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Buildings", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Buildings");
            AlterColumn("dbo.Buildings", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Buildings", "buildingID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Buildings", "buildingID");
        }
    }
}
