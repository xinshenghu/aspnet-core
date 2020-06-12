using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyProjectCore.Web.Views
{
    public abstract class MyProjectCoreViewComponent : AbpViewComponent
    {
        protected MyProjectCoreViewComponent()
        {
            LocalizationSourceName = MyProjectCoreConsts.LocalizationSourceName;
        }
    }
}
