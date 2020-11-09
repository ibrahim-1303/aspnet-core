using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Armut.Authorization;

namespace Armut
{
    [DependsOn(
        typeof(ArmutCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ArmutApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ArmutAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ArmutApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
