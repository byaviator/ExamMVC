using Microsoft.AspNetCore.Mvc;

namespace Soft_Landing.MVC.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
