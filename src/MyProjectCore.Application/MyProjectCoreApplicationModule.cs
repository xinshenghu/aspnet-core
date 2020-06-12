using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProjectCore.Authorization;

namespace MyProjectCore
{
    [DependsOn(
        typeof(MyProjectCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyProjectCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyProjectCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyProjectCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
