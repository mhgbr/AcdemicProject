using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Service;
using System;
using System.Collections.Generic;

namespace MVCProject.Controllers
{
    public class InstructorController : Controller
    {
        public IInstructorService InsRepo { get; }
        public ITrackService TrackRepo { get; }
        public InstructorController(IInstructorService _InsRepo, ITrackService _TrackRepo)
        {
            InsRepo = _InsRepo;
            TrackRepo = _TrackRepo;
        }
        public IActionResult GetAll()
        {
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
                else
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
                    else
                        return Json(false);
                }
            }
        }

        public IActionResult GetInstInTrack(int id)
        {
            List<Instructor> gModel = InsRepo.GetAllInstById(id);
            return PartialView("_", gModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.tracks = TrackRepo.GetAll();
            Instructor ins = new Instructor();
            return View(ins);
        }

        [HttpPost]
        public IActionResult Create(Instructor newins)
        {
            if (ModelState.IsValid)
            {
                InsRepo.Create(newins);
                return RedirectToAction("GetAll");
            }

            List<Track> tracks = TrackRepo.GetAll();
            ViewBag.tracks = tracks;
            return View(newins);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            List<Track> tracks = TrackRepo.GetAll();
            ViewBag.tracks = tracks;

            Instructor std = InsRepo.GetById(id);
            return View(std);
        }
        [HttpPost]
        public IActionResult Update([FromRoute] int id, Instructor newins)
        {
            if (ModelState.IsValid)
            {
                InsRepo.Update(newins);
                return RedirectToAction("GetAll");
            }

            List<Track> tracks = TrackRepo.GetAll();
            ViewBag.tracks = tracks;
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
