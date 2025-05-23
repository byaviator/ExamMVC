using Microsoft.AspNetCore.Mvc;

namespace Soft_Landing.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
