using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Service;
using System;
using System.Collections.Generic;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository StudentServices;
        ITrackService TrackServices;
        //IInstructorRepository InstServices;
        //ICourseRepository CourseServices;

        public StudentController(IStudentRepository _stdRepo, ITrackService _trkRepo /*, IInstructorRepository _instRepo*/)
        {
            StudentServices = _stdRepo; //new StudentRepository();
            TrackServices = _trkRepo;
            // courseServices = _crsRepo;
        }

        public IActionResult GetAll()
        {
            return View(StudentServices.getAll());
        }

        public IActionResult GetById([FromRoute] int id)
        {
            return View(StudentServices.getById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Track> tr = TrackServices.GetAll();
            //ViewData["Trs"] = dept;
            // List<Instructor> inst = InstructorServices.getAll();
            //ViewData["insts"] = inst;
            Student std = new Student();
            return View(std);
        }


        [HttpPost]
        public IActionResult Create(Student newstd)
        {
            if (ModelState.IsValid == true)
            {
                //save db
                StudentServices.Create(newstd);

                //display index view
                return RedirectToAction("GetAll");
            }

            List<Track> trs = TrackServices.GetAll();
            ViewData["Trs"] = trs;
            // List<Instructor> inst = InstructorServices.getAll();
            //ViewData["insts"] = inst;
            //Add
            return View("Add", newstd);//html
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            List<Track> trs = TrackServices.GetAll();
            ViewData["Trs"] = trs;
            //List<Instructor>inst = InstructorServices.getAll();
            //ViewData["insts"] = inst;
            Student std = StudentServices.getById(id);
            return View(std);
        }
        [HttpPost]
        public IActionResult Update(int id, Student newStudent)
        {
            if (ModelState.IsValid == true)
            {

                StudentServices.Update(id, newStudent);
                return RedirectToAction("Index");

            }
            List<Track> trs = TrackServices.GetAll();
            ViewData["Trs"] = trs;
            //List<Instructor> crs = InstructorServices.getAll();
            //ViewData["inst"] = crs;
            return View("Edit", newStudent);
        }


        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                StudentServices.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return View("Update");
            }
        }

        public IActionResult NameExist(string Name, int id)
        {
            //case Add New Student
            if (id == 0)
            {
                Student std = StudentServices.getByName(Name);
                if (std == null)
                    //true
                    return Json(true);
                else //name exists
                     //false
                    return Json(false);
            }
            else  //edit
            {
                Student std = StudentServices.getByName(Name);
                if (std == null)
                    return Json(true); //update name with new value not exist before
                else
                {
                    //id = id parameter ==> true
                    if (std.Id == id)
                        return Json(true);
                    else
                        return Json(false);
                }

            }
        }


        //public IActionResult getStudent(int id)
        //{
        //    Student std = context.Students.FirstOrDefault(s => s.ID == id);

        //    StdWithCr crs =
        //    context.StdWithCr.Include(c => c.Course).Include(ww => ww.Student).FirstOrDefault(ww => ww.tr == id);
        //    StudentWithCrsDegreeVM stdVM = new StudentWithCrsDegreeVM();

        //    stdVM.StudentName = crs.Student.Name;
        //    stdVM.CrsName = crs.Course.Name;
        //    stdVM.Degree = crs.Degree;
        //    stdVM.Id = crs.Id;

        //    return View(stdVM);
        //}



        //public IActionResult getInstructors(int id)
        //{
        //    List<Instructor> instModel = InstServices.getInstructorByID(id);
        //    return View("ShowAllInstructors", instModel);//connection betwen view with model
        //}
    }

}

