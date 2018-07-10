using System.Linq;
using TaawonMVC.EntityFramework;
using TaawonMVC.MultiTenancy;

namespace TaawonMVC.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TaawonMVCDbContext _context;

        public DefaultTenantCreator(TaawonMVCDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
