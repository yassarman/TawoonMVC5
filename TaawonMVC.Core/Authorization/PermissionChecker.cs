using Abp.Authorization;
using TaawonMVC.Authorization.Roles;
using TaawonMVC.Authorization.Users;

namespace TaawonMVC.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
