using Abp.Application.Services;
using FastFootApp.MultiTenancy.Dto;

namespace FastFootApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

