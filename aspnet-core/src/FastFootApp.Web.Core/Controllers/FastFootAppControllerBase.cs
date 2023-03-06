using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FastFootApp.Controllers
{
    public abstract class FastFootAppControllerBase: AbpController
    {
        protected FastFootAppControllerBase()
        {
            LocalizationSourceName = FastFootAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
