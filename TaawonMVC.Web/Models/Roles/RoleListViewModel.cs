using System.Collections.Generic;
using TaawonMVC.Roles.Dto;

namespace TaawonMVC.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}