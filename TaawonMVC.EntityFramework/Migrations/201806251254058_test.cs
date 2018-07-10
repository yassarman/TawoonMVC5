namespace TaawonMVC.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Buildings", "buildingName");
            DropColumn("dbo.Buildings", "isInHoush");
            DropTable("dbo.UsesOfBuildings",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_UsesOfBuilding_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UsesOfBuildings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        usedFor = c.String(nullable: false),
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
                    { "DynamicFilter_UsesOfBuilding_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Buildings", "isInHoush", c => c.Boolean(nullable: false));
            AddColumn("dbo.Buildings", "buildingName", c => c.String());
        }
    }
}
