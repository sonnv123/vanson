using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using vanson.Configuration.Dto;

namespace vanson.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : vansonAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
