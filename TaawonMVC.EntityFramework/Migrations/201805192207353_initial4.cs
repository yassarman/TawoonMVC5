namespace TaawonMVC.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class initial4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32),
                        idNumber = c.Int(nullable: false),
                        propertytId = c.Int(nullable: false),
                        houseHoldNumber = c.Int(nullable: false),
                        phoneNumber = c.String(nullable: false, maxLength: 30),
                        specialNeeds = c.Byte(nullable: false),
                        specialNeedType = c.String(nullable: false, maxLength: 30),
                        alternativeResidence = c.Byte(nullable: false),
                        previousRestortion = c.String(nullable: false, maxLength: 30),
                        previousRestortionDate = c.DateTime(nullable: false),
                        previousRestortionAmount = c.String(maxLength: 30),
                        previousRestortionSource = c.String(nullable: false, maxLength: 30),
                        previousRestortionType = c.String(nullable: false, maxLength: 30),
                        interrestedRepairingEntity = c.Byte(nullable: false),
                        interrestedRepairingEntityName = c.String(nullable: false, maxLength: 30),
                        housingSince = c.DateTime(nullable: false),
                        legalDispute = c.Byte(nullable: false),
                        ownerAgreementEnsured = c.Byte(nullable: false),
                        appliedForMunicipality = c.Byte(nullable: false),
                        restortionType = c.Int(nullable: false),
                        residentStatus = c.Int(nullable: false),
                        ownership = c.Int(nullable: false),
                        propertyType = c.Int(nullable: false),
                        ApplicationRecivedDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        BuildingUnitID = c.Int(nullable: false),
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
                    { "DynamicFilter_Application_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applications",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Application_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
