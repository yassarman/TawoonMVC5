namespace TaawonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTableUploadFilesFieldsToNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UploadFiles", "SourceTableId", c => c.Int());
            AlterColumn("dbo.UploadFiles", "DateEntry", c => c.DateTime());
            AlterColumn("dbo.UploadFiles", "UserId", c => c.Int());
            AlterColumn("dbo.UploadFiles", "NoOfFiles", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UploadFiles", "NoOfFiles", c => c.Int(nullable: false));
            AlterColumn("dbo.UploadFiles", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.UploadFiles", "DateEntry", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UploadFiles", "SourceTableId", c => c.Int(nullable: false));
        }
    }
}
