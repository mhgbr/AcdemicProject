using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCProject.ViewModel;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        public AccountController(UserManager<IdentityUser> _UserManager, SignInManager<IdentityUser> _SignInManager)
        {
            UserManager = _UserManager;
            SignInManager = _SignInManager;
        }

        [HttpGet]
        public IActionResult SignUp(string ReturnUrl = "~/TrackController/GetAll")
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterVM account, string ReturnUrl = "~/TrackController/GetAll")
        {
            if (ModelState.IsValid)
            {
                //map from vm to model
                IdentityUser user = new IdentityUser();
                user.UserName = account.UserName;
                user.Email = account.Email;
                //save in db
                IdentityResult result = await UserManager.CreateAsync(user, account.Password);
                if (result.Succeeded)
                {
                    //create cookie for registeration
                    await SignInManager.SignInAsync(user, account.RememberMe);
                    return LocalRedirect(ReturnUrl);
                }
                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(account);
        }

        [HttpGet]
        public IActionResult Login(string ReturnUrl = "~/TrackController/GetAll")
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM account, string ReturnUrl = "~/TrackController/GetAll")
        {
            if (ModelState.IsValid)
            {
                //find user in db
                IdentityUser user = await UserManager.FindByNameAsync(account.UserName);
                if (user != null)
                {
                    //create cookie for login if user.password == account.Password
                    Microsoft.AspNetCore.Identity.SignInResult result =
                        await SignInManager.PasswordSignInAsync(user, account.Password, account.RememberMe, false);
                    if (result.Succeeded)
                        return LocalRedirect(ReturnUrl);
                    //present error to client that is resulted from error in password
                    ModelState.AddModelError(string.Empty, "invalid password");
                }
                ModelState.AddModelError(string.Empty, "invalid account");
            }
            return View(account);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> EmailExsist(string Email)
        {
            IdentityUser user = await UserManager.FindByEmailAsync(Email);
            if (user == null)
                return Json(true);
            return Json(false);
        }

    }
}
