using System;
using WebApplication.Controllers;
using Xunit;

namespace ContinuousWeb.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void AboutPageTest() 
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
