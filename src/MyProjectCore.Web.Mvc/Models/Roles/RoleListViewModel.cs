using System.Collections.Generic;
using MyProjectCore.Roles.Dto;

namespace MyProjectCore.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
