using System.Threading.Tasks;
using MyProjectCore.Configuration.Dto;

namespace MyProjectCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
