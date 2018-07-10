using System.Collections.Generic;
using TaawonMVC.Roles.Dto;
using TaawonMVC.Users.Dto;

namespace TaawonMVC.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}