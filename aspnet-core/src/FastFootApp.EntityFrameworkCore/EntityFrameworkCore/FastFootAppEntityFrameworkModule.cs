using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using FastFootApp.EntityFrameworkCore.Seed;

namespace FastFootApp.EntityFrameworkCore
{
    [DependsOn(
		typeof(FastFootAppCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class FastFootAppEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
			Configuration.UnitOfWork.IsTransactional = false;

			if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<FastFootAppDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        FastFootAppDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        FastFootAppDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FastFootAppEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
