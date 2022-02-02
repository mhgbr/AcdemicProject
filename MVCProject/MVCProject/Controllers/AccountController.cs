using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCProject.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public AccountController(UserManager<IdentityUser> _UserManager,
            SignInManager<IdentityUser> _SignInManager, RoleManager<IdentityRole> _RoleManager)
        {
            UserManager = _UserManager;
            SignInManager = _SignInManager;
            RoleManager = _RoleManager;
        }

        [HttpGet]
        public IActionResult SignUp(string ReturnUrl = "~/Account/Login")
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterVM account,
            string ReturnUrl = "~/Account/Login")
        {
            if (ModelState.IsValid)
            {
                //map from vm to model
                IdentityUser user = new IdentityUser();
                user.UserName = account.Name;
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
        public IActionResult Login(string ReturnUrl = "~/DashBoard")
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM account,
            string ReturnUrl = "~/DashBoard")
        {
            if (ModelState.IsValid)
            {
                //find user in db
                IdentityUser user = await UserManager.FindByNameAsync(account.Name);
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

        public async Task<IActionResult> Exsist(string Email)
        {
            IdentityUser user = await UserManager.FindByEmailAsync(Email);
            if (user == null)
                return Json(true);
            return Json(false);
        }

        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> AuthorizeUser()
        {
            ViewData["listOfAdmin"] = await UserManager.GetUsersInRoleAsync("admin");
            ViewData["listOfInstructor"] = await UserManager.GetUsersInRoleAsync("instructor");
            ViewData["listOfHr"] = await UserManager.GetUsersInRoleAsync("hr");
            ViewData["listOfStudent"] = await UserManager.GetUsersInRoleAsync("student");
            return View();
        }

        //[Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult SignUpAdmin(string ReturnUrl = "~/Account/AuthorizeUser")
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            ViewData["listOfroles"] = RoleManager.Roles.Select(x => x.Name).ToList();
            ViewData["listOfUser"] = UserManager.Users.Select(x => x.UserName).ToList();
            return View("SignUpAdmin");
        }
        [HttpPost]

        public async Task<IActionResult> SignUpAdmin(string name, string roleName,
            string ReturnUrl = "~/Account/AuthorizeUser")
        {
            IdentityUser user = await UserManager.FindByNameAsync(name);
            //save in db
            if (user != null)
            {
                //add roles
                IdentityResult role = await UserManager.AddToRoleAsync(user, roleName);
                if (role.Succeeded)
                {
                    return LocalRedirect(ReturnUrl);
                }
                ModelState.AddModelError(string.Empty, "no role found");
            }
            ModelState.AddModelError(string.Empty, "no user found");
            ViewData["listOfroles"] = RoleManager.Roles.Select(x => x.Name).ToList();
            ViewData["listOfUser"] = UserManager.Users.Select(x => x.UserName).ToList();
            return View();
        }





    }
}
