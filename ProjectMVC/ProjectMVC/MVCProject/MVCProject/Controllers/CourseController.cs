using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Service;
using System;

namespace MVCProject.Controllers
{
    public class CourseController : Controller
    {
        public ICourseService course { get; }
        public CourseController(ICourseService _course)
        {
            course = _course;
        }

        public IActionResult GetAll()
        {
            return View(course.GetAll());
        }

        public IActionResult GetById([FromRoute] int id)
        {
            return View(course.GetById(id));
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
                course.Create(crs);
                return RedirectToAction("GetAll");
            }
            else
                return View(crs);
        }

        public IActionResult Update(int id)
        {
            Course crs = course.GetById(id);
            return View(crs);
        }

        public IActionResult Update([FromRoute] int id, Course crs)
        {
            if (ModelState.IsValid)
            {
                course.Update(id, crs);
                return RedirectToAction("GetAll");
            }
            else
                return View(crs);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                course.Delete(id);
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
                Course crs = course.GetById(id);
                if (crs == null)
                    return Json(true);
                else
                    return Json(false);

            }
            else
            {
                Course crs = course.GetByName(Name);
                if (crs == null)
                    return Json(true);
                else
                {
                    if (crs.Id == id)
                        return Json(true);
                    else
                        return Json(false);
                }
            }
        }




    }
}
