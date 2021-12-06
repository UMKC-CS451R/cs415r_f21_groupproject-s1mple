using Xunit;
using Commerce.Controllers;
using Commerce.Repository;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace CommerceTests
{
    public class AllSecurityControllerTest
    {
        [Fact]
        public async void CheckLoginRedirectsToWelcomeWithValidData()
        {
            // Arrange
            var mockContext = new Mock<AppDbContext>();
            var controller = new AllSecurityController(mockContext.Object);
            // mockContext.Setup(m=>m.)

            // Act
            /*var result = await controller.Welcome();

            // Assert
            var redirectToActionResult = 
                Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("AllSecurity", redirectToActionResult.ControllerName);
            Assert.Equal("Welcome", redirectToActionResult.ActionName);
            */
        }
    }
}