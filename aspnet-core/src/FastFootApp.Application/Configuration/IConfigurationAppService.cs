using System.Threading.Tasks;
using FastFootApp.Configuration.Dto;

namespace FastFootApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
