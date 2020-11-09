using System.Threading.Tasks;
using Armut.Models.TokenAuth;
using Armut.Web.Controllers;
using Shouldly;
using Xunit;

namespace Armut.Web.Tests.Controllers
{
    public class HomeController_Tests: ArmutWebTestBase
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