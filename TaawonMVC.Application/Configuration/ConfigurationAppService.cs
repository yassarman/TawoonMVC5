using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TaawonMVC.Configuration.Dto;

namespace TaawonMVC.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TaawonMVCAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
