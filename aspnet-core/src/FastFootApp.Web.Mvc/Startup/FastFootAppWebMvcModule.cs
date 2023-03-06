using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FastFootApp.Configuration;

namespace FastFootApp.Web.Startup
{
    [DependsOn(typeof(FastFootAppWebCoreModule))]
    public class FastFootAppWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FastFootAppWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<FastFootAppNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FastFootAppWebMvcModule).GetAssembly());
        }
    }
}
