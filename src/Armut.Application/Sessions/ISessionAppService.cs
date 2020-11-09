using System.Threading.Tasks;
using Abp.Application.Services;
using Armut.Sessions.Dto;

namespace Armut.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
