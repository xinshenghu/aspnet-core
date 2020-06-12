using Abp.Authorization;
using MyProjectCore.Authorization.Roles;
using MyProjectCore.Authorization.Users;

namespace MyProjectCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
