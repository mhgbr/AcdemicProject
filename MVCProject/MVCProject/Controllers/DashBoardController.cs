using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class DashBoardController : Controller
    {


        [Route("Dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
