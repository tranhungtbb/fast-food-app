using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using FastFootApp.Controllers;

namespace FastFootApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FastFootAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
