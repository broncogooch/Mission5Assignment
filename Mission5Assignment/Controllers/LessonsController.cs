using Microsoft.AspNetCore.Mvc;
using Mission5Assignment.Models;
using System.Diagnostics;

namespace Mission5Assignment.Controllers
{
    public class LessonsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public LessonsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Lessons()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
