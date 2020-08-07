using Microsoft.AspNetCore.Mvc;

namespace TestingAspNetCoreMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}