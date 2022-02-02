using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCProject.Models;
using System.Diagnostics;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
     
        public IActionResult Home()
        {
            return View();
        }

        [Route("Courses")]
        public IActionResult courses()
        {
            return View();
        }

        [Route("Instructors")]
        public IActionResult Instractors()
        {
            return View();
        }

        [Route("Pricing")]
        public IActionResult pricing()
        {
            return View();
        }

        [Route("About")]
        public IActionResult about()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        [Route("Error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
