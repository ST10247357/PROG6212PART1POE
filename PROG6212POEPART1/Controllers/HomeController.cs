using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROG6212POEPART1.Models;

namespace PROG6212POEPART1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
