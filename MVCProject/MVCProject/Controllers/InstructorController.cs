using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Models;
using MVCProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    
    public class InstructorController : Controller
    {
        public IInstructorService InsRepo { get; }
        public ITrackService TrackRepo { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public InstructorController(IInstructorService _InsRepo,
            ITrackService _TrackRepo, UserManager<IdentityUser> _UserManager,
            SignInManager<IdentityUser> _SignInManager, RoleManager<IdentityRole> _RoleManager)
        {
            InsRepo = _InsRepo;
            TrackRepo = _TrackRepo;
            UserManager = _UserManager;
            SignInManager = _SignInManager;
            RoleManager = _RoleManager;
        }



        [Authorize(Roles = "admin")]
        public IActionResult GetAll()
        {
            ViewData["trackName"] = TrackRepo.GetAll();
            return View(InsRepo.GetAll());
        }
        public IActionResult GetById([FromRoute] int id)
        {
            return View(InsRepo.GetById(id));
        }

        public IActionResult NameExit(string Name, int id)
        {
            Instructor ins = InsRepo.GetByName(Name);
            if (id == 0)   //add
            {
                if (ins == null)
                    return Json(true);
                return Json(false);
            }
            else           //edit
            {
                if (ins == null)
                    return Json(true);
                else
                {
                    if (ins.Id == id)
                        return Json(true);
                    return Json(false);
                }
            }
        }

        public IActionResult GetInstInTrack([FromRoute] int id)
        {
            ViewBag.tracks = TrackRepo.GetAll();
            List<Instructor> gModel = InsRepo.GetAllInstById(id);
            return PartialView("_GetInstInTrack", gModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            //user.Include(u => u.Roles)
            ViewData["listOfUser"] = await UserManager.GetUsersInRoleAsync("instructor");
            ViewBag.tracks = TrackRepo.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Instructor newstd)
        {
            if (ModelState.IsValid)
            {
                InsRepo.Create(newstd);
                return RedirectToAction("GetAll");
            }
            ViewData["tracks"] = TrackRepo.GetAll();
            return View(newstd);
        }



        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.tracks = TrackRepo.GetAll();
            Instructor std = InsRepo.GetById(id);
            return View(std);
        }
        [HttpPost]
        public IActionResult Update(Instructor newins)
        {
            if (ModelState.IsValid)
            {
                InsRepo.Update(newins);
                return RedirectToAction("GetAll");
            }
            ViewBag.tracks = TrackRepo.GetAll();
            return View(newins);

        }
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                InsRepo.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                return View();
            }
        }



    }
}
