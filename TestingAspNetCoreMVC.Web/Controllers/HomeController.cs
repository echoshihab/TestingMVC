using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestingAspNetCoreMVC.Web.Models;

namespace TestingAspNetCoreMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var users = new List<User>{
                new User {ID = 1, Name = "Shihab", Role = "Coordinator"},
                new User {ID =2, Name ="James", Role = "Admin"}
            };
            return View(users);
        }
    }
}