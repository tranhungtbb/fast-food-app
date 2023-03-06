using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FastFootApp.EntityFrameworkCore;
using FastFootApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FastFootApp.Web.Tests
{
    [DependsOn(
        typeof(FastFootAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FastFootAppWebTestModule : AbpModule
    {
        public FastFootAppWebTestModule(FastFootAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FastFootAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FastFootAppWebMvcModule).Assembly);
        }
    }
}