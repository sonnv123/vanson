using Abp.Application.Services;
using vanson.MultiTenancy.Dto;

namespace vanson.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

