using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pronia.DAL;
using Pronia.Models;
using Pronia.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.sliders.ToList();
            List<Product> products = _context.products.OrderByDescending(p=>p.Id).Take(8).ToList();
            ViewModel_one viewModel = new ViewModel_one() { sliders = sliders,products = products};
            return View(viewModel);
        }

      
    }
}
