using System.Threading.Tasks;
using Abp.Application.Services;
using FastFootApp.Authorization.Accounts.Dto;

namespace FastFootApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
