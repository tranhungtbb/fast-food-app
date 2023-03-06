using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FastFootApp.Configuration;
using FastFootApp.EntityFrameworkCore;
using FastFootApp.Migrator.DependencyInjection;

namespace FastFootApp.Migrator
{
    [DependsOn(typeof(FastFootAppEntityFrameworkModule))]
    public class FastFootAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FastFootAppMigratorModule(FastFootAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(FastFootAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                FastFootAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FastFootAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
