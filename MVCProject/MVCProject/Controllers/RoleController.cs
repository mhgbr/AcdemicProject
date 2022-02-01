using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    [Authorize(Roles = "admin")]
    public class RoleController : Controller
    {
        public RoleManager<IdentityRole> RoleManager { get; }
        public RoleController(RoleManager<IdentityRole> _RoleManager)
        {
            RoleManager = _RoleManager;
        }

        public IActionResult GetAll()
        {
            List<string> roleList = RoleManager.Roles.Select(x => x.Name).ToList();
            return View(roleList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleVM role)
        {
            if (ModelState.IsValid)
            {
                //map from vm to model
                IdentityRole myRole = new IdentityRole() { Name = role.Name };
                //save in db
                IdentityResult result = await RoleManager.CreateAsync(myRole);
                if (result.Succeeded)
                    return RedirectToAction("GetAll");
                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(role);
        }

        public async Task<IActionResult> Delete(string name)
        {
            IdentityRole role = await RoleManager.FindByNameAsync(name);
            try
            {
                await RoleManager.DeleteAsync(role);
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.InnerException.Message);
            }
            return View("GetAll");
        }
        public async Task<IActionResult> Exsist(string Name)
        {
            IdentityRole role = await RoleManager.FindByNameAsync(Name);
            if (role == null)
                return Json(true);
            return Json(false);
        }


    }
}
