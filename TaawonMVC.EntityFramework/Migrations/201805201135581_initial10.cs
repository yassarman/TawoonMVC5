namespace TaawonMVC.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class initial10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        buildingID = c.Int(nullable: false, identity: true),
                        numOfBuildingUnits = c.Int(nullable: false),
                        numOfFloors = c.Int(nullable: false),
                        streetName = c.String(nullable: false, maxLength: 500),
                        buildingNo = c.Int(nullable: false),
                        neighborhoodID = c.Int(nullable: false),
                        buildingTypeID = c.Int(nullable: false),
                        GISMAP = c.String(maxLength: 500),
                        houshProperty = c.Byte(nullable: false),
                        houshName = c.String(maxLength: 500),
                        X = c.Double(nullable: false),
                        Y = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Id = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Buildings_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.buildingID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Buildings",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Buildings_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
