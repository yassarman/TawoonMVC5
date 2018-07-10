using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TaawonMVC.MultiTenancy.Dto;

namespace TaawonMVC.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
