using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyProjectCore.Controllers
{
    public abstract class MyProjectCoreControllerBase: AbpController
    {
        protected MyProjectCoreControllerBase()
        {
            LocalizationSourceName = MyProjectCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
