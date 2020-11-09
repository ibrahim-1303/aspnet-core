using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Armut.Web.Views
{
    public abstract class ArmutRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ArmutRazorPage()
        {
            LocalizationSourceName = ArmutConsts.LocalizationSourceName;
        }
    }
}
