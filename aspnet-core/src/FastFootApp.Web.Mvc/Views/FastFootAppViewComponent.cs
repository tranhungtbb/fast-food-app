using Abp.AspNetCore.Mvc.ViewComponents;

namespace FastFootApp.Web.Views
{
    public abstract class FastFootAppViewComponent : AbpViewComponent
    {
        protected FastFootAppViewComponent()
        {
            LocalizationSourceName = FastFootAppConsts.LocalizationSourceName;
        }
    }
}
