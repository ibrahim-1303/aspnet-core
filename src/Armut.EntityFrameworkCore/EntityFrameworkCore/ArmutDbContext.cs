using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Armut.Authorization.Roles;
using Armut.Authorization.Users;
using Armut.MultiTenancy;

namespace Armut.EntityFrameworkCore
{
    public class ArmutDbContext : AbpZeroDbContext<Tenant, Role, User, ArmutDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ArmutDbContext(DbContextOptions<ArmutDbContext> options)
            : base(options)
        {
        }
    }
}
