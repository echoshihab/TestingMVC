using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestingAspNetCoreMVC.Web.Data.Repository.IRepository;
using TestingAspNetCoreMVC.Web.Models;

namespace TestingAspNetCoreMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var users = _userRepository.ListUsers();

            return View(users);
        }

        public IActionResult Details(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return View("NotFound");
            }
            return View(user);
        }

        [Route("home/role/{role}")]
        public IActionResult Role(string role)
        {
            var user = _userRepository.GetUserByRole(role);
            if (user == null)
            {
                return View("NotFound");
            }
            return View(user);
        }
    }
}