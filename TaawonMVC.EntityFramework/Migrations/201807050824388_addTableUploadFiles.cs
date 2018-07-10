namespace TaawonMVC.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class addTableUploadFiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UploadFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 50),
                        FileData = c.Binary(),
                        Type = c.String(maxLength: 50),
                        SourceTable = c.String(maxLength: 50),
                        SourceTableId = c.Int(nullable: false),
                        Description = c.String(maxLength: 50),
                        DateEntry = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        NoOfFiles = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_UploadFiles_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UploadFiles",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_UploadFiles_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
