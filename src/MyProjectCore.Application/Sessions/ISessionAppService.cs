using System.Threading.Tasks;
using Abp.Application.Services;
using MyProjectCore.Sessions.Dto;

namespace MyProjectCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
