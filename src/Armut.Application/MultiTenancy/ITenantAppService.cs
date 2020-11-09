using Abp.Application.Services;
using Armut.MultiTenancy.Dto;

namespace Armut.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

