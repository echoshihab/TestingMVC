using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestingAspNetCoreMVC.Web.Controllers;
using TestingAspNetCoreMVC.Web.Models;
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

        [Fact]
        public void VerifyCountOfUsers()
        {
            var controller = new HomeController();
            var result = Assert.IsType<ViewResult>(controller.List());
            var model = Assert.IsType<List<User>>(result.Model);
            Assert.Equal(2, model.Count());

        }
    }
}
