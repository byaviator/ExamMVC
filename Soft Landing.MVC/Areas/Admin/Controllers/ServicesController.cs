using Microsoft.AspNetCore.Mvc;
using Soft_Landing.DAL.Models;
using Soft_Landing.BL.ModelViews;

namespace Soft_Landing.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StaffModelCreateVM staffModelCreateVM )
        {
            




        }
    }
}
