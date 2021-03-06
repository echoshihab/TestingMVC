using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TestingAspNetCoreMVC.Web.Controllers;
using TestingAspNetCoreMVC.Web.Data.Repository;
using TestingAspNetCoreMVC.Web.Data.Repository.IRepository;
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
            var repository = new Mock<IUserRepository>();
            var controller = new HomeController(repository.Object);
            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void VerifyCountOfUsers()
        {
            var repository = new Mock<IUserRepository>();
            repository.Setup(x => x.ListUsers()).Returns(new List<User>{
                new User(), new User()
            });
            var controller = new HomeController(repository.Object);
            var result = Assert.IsType<ViewResult>(controller.List());
            var model = Assert.IsType<List<User>>(result.Model);
            Assert.Equal(2, model.Count());

        }

        [Fact]
        public void CanRetrieveUserByValidID()
        {
            var repository = new Mock<IUserRepository>();
            repository.Setup(x => x.GetUserById(It.IsInRange<int>(1, 2, Moq.Range.Inclusive))).Returns(new User
            {
                ID = 1,
                Name = "Shihab",
                Role = "Coordinator"
            });
            var controller = new HomeController(repository.Object);
            var result = Assert.IsType<ViewResult>(controller.Details(1));
            var model = Assert.IsType<User>(result.Model);
            Assert.Equal("Shihab", model.Name);
        }

        [Fact]
        public void InvalidIdReturnsNotFound()
        {
            var repository = new Mock<IUserRepository>();
            repository.Setup(x => x.GetUserById(It.Is<int>(id => id > 2))).Returns((User)null);
            var controller = new HomeController(repository.Object);
            var result = Assert.IsType<ViewResult>(controller.Details(4));
            Assert.Null(result.Model);
        }




    }
}
