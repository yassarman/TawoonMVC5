using System.Threading.Tasks;
using Abp.Application.Services;
using TaawonMVC.Authorization.Accounts.Dto;

namespace TaawonMVC.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
