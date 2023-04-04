using System.Threading.Tasks;
using vanson.Configuration.Dto;

namespace vanson.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
