﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Service;
using System;

namespace MVCProject.Controllers
{
    public class CourseController : Controller
    {
        public ICourseService Course { get; }
        public ITrackService TrackServices { get; }
        public CourseController(ICourseService _course, ITrackService _trkRepo)
        {
            Course = _course;
            TrackServices = _trkRepo;
        }

        [Route("CourseData")]
        public IActionResult GetAll()
        {
            ViewBag.tracks = TrackServices.GetAll();
            return View(Course.GetAll());
        }

        public IActionResult GetById([FromRoute] int id)
        {
            return View(Course.GetById(id));
        }

        [HttpGet]

        public IActionResult Create()
        {
            ViewData["Trs"] = TrackServices.GetAll();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Create(Course crs)
        {
            if (ModelState.IsValid)
            {
                Course.Create(crs);
                return RedirectToAction("GetAll");
            }
            ViewData["Trs"] = TrackServices.GetAll();
            return View(crs);
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Update(int id)
        {
            ViewData["Trs"] = TrackServices.GetAll();
            Course crs = Course.GetById(id);
            return View(crs);
        }

        [HttpPost]
        public IActionResult Update(Course crs)
        {
            if (ModelState.IsValid)
            {
                Course.Update(crs);
                return RedirectToAction("GetAll");
            }
            ViewData["Trs"] = TrackServices.GetAll();
            return View(crs);
        }

        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            try
            {
                Course.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch
            {
                ModelState.AddModelError("Exception", "This Item is in use");
                return View("GetAll");
            }
        }

        public IActionResult IsExist(string Name, int id)
        {
            if (id == 0)
            {
                Course crs = Course.GetById(id);
                if (crs == null)
                    return Json(true);
                return Json(false);

            }
            else
            {
                Course crs = Course.GetByName(Name);
                if (crs == null)
                    return Json(true);
                else
                {
                    if (crs.Id == id)
                        return Json(true);
                    return Json(false);
                }
            }
        }

    }
}
