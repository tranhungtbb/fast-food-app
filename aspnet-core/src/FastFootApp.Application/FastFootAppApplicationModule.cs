using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FastFootApp.Authorization;

namespace FastFootApp
{
    [DependsOn(
        typeof(FastFootAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FastFootAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FastFootAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FastFootAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
