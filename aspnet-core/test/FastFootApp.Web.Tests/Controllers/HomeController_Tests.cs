using System.Threading.Tasks;
using FastFootApp.Models.TokenAuth;
using FastFootApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace FastFootApp.Web.Tests.Controllers
{
    public class HomeController_Tests: FastFootAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}