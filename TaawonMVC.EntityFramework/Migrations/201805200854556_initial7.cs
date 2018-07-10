namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Neighborhoods", "AName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Neighborhoods", "EName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Neighborhoods", "EName");
            DropColumn("dbo.Neighborhoods", "AName");
        }
    }
}
