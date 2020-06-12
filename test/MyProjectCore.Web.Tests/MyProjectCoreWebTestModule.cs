using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProjectCore.EntityFrameworkCore;
using MyProjectCore.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyProjectCore.Web.Tests
{
    [DependsOn(
        typeof(MyProjectCoreWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyProjectCoreWebTestModule : AbpModule
    {
        public MyProjectCoreWebTestModule(MyProjectCoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectCoreWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyProjectCoreWebMvcModule).Assembly);
        }
    }
}