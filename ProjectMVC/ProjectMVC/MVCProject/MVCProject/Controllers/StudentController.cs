using Day1.Services;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Collections.Generic;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository StudentServices;
       // ITrackRepository TrackServices;
       // IInstructorRepository InstServices;
        //CrsEntities context = new CrsEntities();
        public StudentController(IStudentRepository _stdRepo, /*ITrackRepository _trkRepo, IInstructorRepository _instRepo*/)
        {
            StudentServices = _stdRepo; //new StudentRepository();
           // departmentServices = _deptRepo;
           // courseServices = _crsRepo;
        }

        public IActionResult Index()
        {
            List<Student> stdModel = StudentServices.getAll();
            return View("Index", stdModel);
        }

        public IActionResult Add()
        {
            //List<Track> tr = TrackServices.getAll();
            //ViewData["Trs"] = dept;
           // List<Instructor> inst = InstructorServices.getAll();
            //ViewData["insts"] = inst;
            Student std = new Student();
            return View(std);
        }
        [HttpPost]
        public IActionResult SaveAdd(Student newstd)
        {
            if (ModelState.IsValid == true)
            {
                //save db
                StudentServices.Create(newstd);

                //display index view
                return RedirectToAction("Index");
            }

            //List<Track> dept = TrackServices.getAll();
            //ViewData["Trs"] = dept;
           // List<Instructor> inst = InstructorServices.getAll();
            //ViewData["insts"] = inst;
            //Add
            return View("Add", newstd);//html
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            //List<Track> trs = TrackServices.getAll();
            //ViewData["Trs"] = trs;
            //List<Instructor>inst = InstructorServices.getAll();
            //ViewData["insts"] = inst;
            Student inst = StudentServices.getById(id);
            return View(inst);
        }

        public IActionResult SaveEdit(int id, Student newStudent)
        {
            if (ModelState.IsValid == true)
            {

                StudentServices.Update(id, newStudent);
                return RedirectToAction("Index");

            }
            //List<Track> trs = TrackServices.getAll();
            //ViewData["Trs"] = trs;
            //List<Instructor> crs = InstructorServices.getAll();
            //ViewData["inst"] = crs;
            return View("Edit", newStudent);
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

        public IActionResult GetInstructor(int id)
        {
            List<Student> stdModel = StudentServices.getStudentByTrackId(id);
            return PartialView("_StudentCard", stdModel);
        }
    }

}
}
