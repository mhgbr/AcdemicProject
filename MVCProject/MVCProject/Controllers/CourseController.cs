using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Service;
using System;

namespace MVCProject.Controllers
{
    public class CourseController : Controller
    {
        public ICourseService Course { get; }
        public CourseController(ICourseService _course)
        {
            Course = _course;
        }

        public IActionResult GetAll()
        {
            return View(Course.GetAll());
        }

        public IActionResult GetById([FromRoute] int id)
        {
            return View(Course.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course crs)
        {
            if (ModelState.IsValid)
            {
                Course.Create(crs);
                return RedirectToAction("GetAll");
            }
            return View(crs);
        }

        public IActionResult Update(int id)
        {
            Course crs = Course.GetById(id);
            return View(crs);
        }

        public IActionResult Update([FromRoute] int id, Course crs)
        {
            if (ModelState.IsValid)
            {
                Course.Update(id, crs);
                return RedirectToAction("GetAll");
            }
            return View(crs);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                Course.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Exception", ex.InnerException.Message);//
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
