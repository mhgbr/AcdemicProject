using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class Account : Controller
    {
        public UserManager<IdentityUser> User_Manager { get; }
        public SignInManager<IdentityUser> MyProperty { get; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
