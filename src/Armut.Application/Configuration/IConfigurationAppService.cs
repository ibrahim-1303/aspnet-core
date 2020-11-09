using System.Threading.Tasks;
using Armut.Configuration.Dto;

namespace Armut.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
