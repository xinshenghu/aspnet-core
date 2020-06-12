using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyProjectCore.Configuration.Dto;

namespace MyProjectCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyProjectCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
