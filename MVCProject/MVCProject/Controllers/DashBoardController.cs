using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
