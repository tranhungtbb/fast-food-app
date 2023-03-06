using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FastFootApp.Configuration;

namespace FastFootApp.Web.Host.Startup
{
    [DependsOn(
       typeof(FastFootAppWebCoreModule))]
    public class FastFootAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FastFootAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FastFootAppWebHostModule).GetAssembly());
        }
    }
}
