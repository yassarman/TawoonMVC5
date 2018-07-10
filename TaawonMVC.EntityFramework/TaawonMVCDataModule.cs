using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using TaawonMVC.EntityFramework;

namespace TaawonMVC
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TaawonMVCCoreModule))]
    public class TaawonMVCDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TaawonMVCDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
