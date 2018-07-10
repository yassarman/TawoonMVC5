namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BuildingTypes", "AName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.BuildingTypes", "EName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Neighborhoods", "AName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Neighborhoods", "EName", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Neighborhoods", "EName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Neighborhoods", "AName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.BuildingTypes", "EName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.BuildingTypes", "AName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
