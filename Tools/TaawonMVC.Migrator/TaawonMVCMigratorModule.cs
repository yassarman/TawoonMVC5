using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TaawonMVC.EntityFramework;

namespace TaawonMVC.Migrator
{
    [DependsOn(typeof(TaawonMVCDataModule))]
    public class TaawonMVCMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TaawonMVCDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}