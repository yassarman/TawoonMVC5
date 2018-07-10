using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using TaawonMVC.Authorization.Roles;
using TaawonMVC.Authorization.Users;
using TaawonMVC.Models;
using TaawonMVC.MultiTenancy;

namespace TaawonMVC.EntityFramework
{
    public class TaawonMVCDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TaawonMVCDbContext()
            : base("Default")
        {

        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Neighborhood> Neighborhoods { get; set; }
        public virtual DbSet<BuildingType> BuildingTypes { get; set; }
        public virtual DbSet<Buildings> Buildings { get; set; } 
        public virtual DbSet<BuildingUses> BuildingUses { get; set; }
        public virtual DbSet<UploadFiles> UploadFiles { get; set; }
        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TaawonMVCDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TaawonMVCDbContext since ABP automatically handles it.
         */
        public TaawonMVCDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TaawonMVCDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TaawonMVCDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
