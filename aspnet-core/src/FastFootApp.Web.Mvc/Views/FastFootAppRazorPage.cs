using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FastFootApp.Web.Views
{
    public abstract class FastFootAppRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FastFootAppRazorPage()
        {
            LocalizationSourceName = FastFootAppConsts.LocalizationSourceName;
        }
    }
}
