using System.Threading.Tasks;
using vanson.Models.TokenAuth;
using vanson.Web.Controllers;
using Shouldly;
using Xunit;

namespace vanson.Web.Tests.Controllers
{
    public class HomeController_Tests: vansonWebTestBase
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