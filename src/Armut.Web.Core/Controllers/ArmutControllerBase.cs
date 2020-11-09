using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Armut.Controllers
{
    public abstract class ArmutControllerBase: AbpController
    {
        protected ArmutControllerBase()
        {
            LocalizationSourceName = ArmutConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
