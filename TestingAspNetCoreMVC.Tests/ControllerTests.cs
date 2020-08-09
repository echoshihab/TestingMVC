using System;
using Microsoft.AspNetCore.Mvc;
using TestingAspNetCoreMVC.Web.Controllers;
using Xunit;

namespace TestingAspNetCoreMVC.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void IndexViewTypeEqualsViewResult()
        {
            //Arrange
            var controller = new HomeController();
            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
