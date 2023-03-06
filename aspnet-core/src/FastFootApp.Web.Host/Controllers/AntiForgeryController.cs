using System.Threading.Tasks;
using Abp.Web.Security.AntiForgery;
using Microsoft.AspNetCore.Antiforgery;
using FastFootApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace FastFootApp.Web.Host.Controllers
{
    public class AntiForgeryController : FastFootAppControllerBase
    {
        private readonly IAntiforgery _antiforgery;
        private readonly IAbpAntiForgeryManager _antiForgeryManager;

        public AntiForgeryController(IAntiforgery antiforgery, IAbpAntiForgeryManager antiForgeryManager)
        {
            _antiforgery = antiforgery;
            _antiForgeryManager = antiForgeryManager;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }

        public void SetCookie()
        {
            _antiForgeryManager.SetCookie(HttpContext);
        }
    }
}
