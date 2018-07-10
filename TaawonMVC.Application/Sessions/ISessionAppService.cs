using System.Threading.Tasks;
using Abp.Application.Services;
using TaawonMVC.Sessions.Dto;

namespace TaawonMVC.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
