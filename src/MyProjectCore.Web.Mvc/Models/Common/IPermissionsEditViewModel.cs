using System.Collections.Generic;
using MyProjectCore.Roles.Dto;

namespace MyProjectCore.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}