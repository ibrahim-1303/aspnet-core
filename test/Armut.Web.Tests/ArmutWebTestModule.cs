using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Armut.EntityFrameworkCore;
using Armut.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Armut.Web.Tests
{
    [DependsOn(
        typeof(ArmutWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ArmutWebTestModule : AbpModule
    {
        public ArmutWebTestModule(ArmutEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ArmutWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ArmutWebMvcModule).Assembly);
        }
    }
}