using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyProjectCore.Authorization.Roles;
using MyProjectCore.Authorization.Users;
using MyProjectCore.MultiTenancy;

namespace MyProjectCore.EntityFrameworkCore
{
    public class MyProjectCoreDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyProjectCoreDbContext(DbContextOptions<MyProjectCoreDbContext> options)
            : base(options)
        {
        }
    }
}
