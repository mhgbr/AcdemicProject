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

        // Track/GetAll
        [Route("Tracks")]
        public IActionResult GetAll()
        {
            return View(TrackRepo.GetAll());
        }

        public IActionResult GetById([FromRoute] int id)
        {
            return View(TrackRepo.GetById(id));
        }

        // Track/Create
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
            return View(Track);
        }

        // Track/Update
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
            return View(track);
        }

        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                TrackRepo.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch
            {
                ModelState.AddModelError("", "You cant delete this track");
                return View("ErrorPage");
            }
        }

        public IActionResult Exisit(int id, string Name)
        {
            var track = TrackRepo.GetByName(Name);
            if (id == 0)
            {
                if (track == null)
                    return Json(true);
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
                    return Json(false);
                }
            }
        }
    }
}
