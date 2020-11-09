using System.Threading.Tasks;
using Abp.Application.Services;
using Armut.Authorization.Accounts.Dto;

namespace Armut.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
