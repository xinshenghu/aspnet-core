using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MyProjectCore.Web.Views
{
    public abstract class MyProjectCoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyProjectCoreRazorPage()
        {
            LocalizationSourceName = MyProjectCoreConsts.LocalizationSourceName;
        }
    }
}
