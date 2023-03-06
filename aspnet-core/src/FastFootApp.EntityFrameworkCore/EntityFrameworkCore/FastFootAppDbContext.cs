using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FastFootApp.Authorization.Roles;
using FastFootApp.Authorization.Users;
using FastFootApp.MultiTenancy;

namespace FastFootApp.EntityFrameworkCore
{
    public class FastFootAppDbContext : AbpZeroDbContext<Tenant, Role, User, FastFootAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FastFootAppDbContext(DbContextOptions<FastFootAppDbContext> options)
            : base(options)
        {
        }
    }
}
