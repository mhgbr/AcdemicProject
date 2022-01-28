using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Service;
using System;

namespace pproject.Controllers
{
    public class TrackController : Controller
    {
        // injection
        public ITrackService TrackRepo { get; }
        public TrackController(ITrackService trackRepo)
        {
            TrackRepo = trackRepo;
        }
        public IActionResult GetAll()
        {
            return View(TrackRepo.GetAll());
        }

        public IActionResult GetById([FromRoute] int id)
        {
            return View(TrackRepo.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Track Track)
        {
            if (!ModelState.IsValid)
            {
                TrackRepo.Create(Track);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View(Track);
            }
        }

        [HttpGet]
        public IActionResult Update([FromRoute] int id)
        {
            return View(TrackRepo.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Track track)
        {
            if (ModelState.IsValid)
            {
                TrackRepo.Update(track);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View(track);
            }
        }

        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                TrackRepo.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return View("Update");
            }
        }

        public IActionResult NameExisit(int id, string Name)
        {
            var track = TrackRepo.GetByName(Name);
            if (id == 0)
            {
                if (track == null)
                    return Json(true);
                else
                    return Json(false);
            }
            else
            {
                if (track == null)
                    return Json(true);
                else
                {
                    if (id == track.Id)
                        return Json(true);
                    else
                        return Json(false);
                }
            }
        }
    }
}
