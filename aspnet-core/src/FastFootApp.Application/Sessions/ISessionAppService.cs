using System.Threading.Tasks;
using Abp.Application.Services;
using FastFootApp.Sessions.Dto;

namespace FastFootApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
