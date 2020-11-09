using Abp.AspNetCore.Mvc.ViewComponents;

namespace Armut.Web.Views
{
    public abstract class ArmutViewComponent : AbpViewComponent
    {
        protected ArmutViewComponent()
        {
            LocalizationSourceName = ArmutConsts.LocalizationSourceName;
        }
    }
}
