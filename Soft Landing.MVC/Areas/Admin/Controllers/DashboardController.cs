using Microsoft.AspNetCore.Mvc;

namespace Soft_Landing.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Tables()
        {
            return View();

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
