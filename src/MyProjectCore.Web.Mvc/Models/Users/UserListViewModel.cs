using System.Collections.Generic;
using MyProjectCore.Roles.Dto;

namespace MyProjectCore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
