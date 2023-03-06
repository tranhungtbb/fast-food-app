using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FastFootApp.Configuration.Dto;

namespace FastFootApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FastFootAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
