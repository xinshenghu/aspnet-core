using System.Threading.Tasks;
using MyProjectCore.Models.TokenAuth;
using MyProjectCore.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyProjectCore.Web.Tests.Controllers
{
    public class HomeController_Tests: MyProjectCoreWebTestBase
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