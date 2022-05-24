using Microsoft.AspNetCore.Mvc;

namespace FrontBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Our-Site | Contact";
            return View();
        }
    }
}
