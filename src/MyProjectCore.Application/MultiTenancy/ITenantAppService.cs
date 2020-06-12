using Abp.Application.Services;
using MyProjectCore.MultiTenancy.Dto;

namespace MyProjectCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

