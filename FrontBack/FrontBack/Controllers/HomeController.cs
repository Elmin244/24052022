using Microsoft.AspNetCore.Mvc;

namespace FrontBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Our-Site | Home";
            return View();
        }
    }
}
