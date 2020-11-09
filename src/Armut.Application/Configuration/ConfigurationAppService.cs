using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Armut.Configuration.Dto;

namespace Armut.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ArmutAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
