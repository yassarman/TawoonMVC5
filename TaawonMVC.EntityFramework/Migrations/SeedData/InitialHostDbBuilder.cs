using TaawonMVC.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TaawonMVC.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TaawonMVCDbContext _context;

        public InitialHostDbBuilder(TaawonMVCDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
