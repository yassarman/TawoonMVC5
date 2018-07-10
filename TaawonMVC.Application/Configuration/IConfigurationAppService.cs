using System.Threading.Tasks;
using Abp.Application.Services;
using TaawonMVC.Configuration.Dto;

namespace TaawonMVC.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}