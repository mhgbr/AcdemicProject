using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Service;
using MVCProject.ViewModel;
using System;
using System.Linq;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        public IStudentService StudentServices { get; }
        public ITrackService TrackServices { get; }
        public IInstructorService InstructorServices { get; }
        public IStdWithCrService IStdWithCrService { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }

        public StudentController(IStudentService _stdRepo,
            ITrackService _trkRepo, IInstructorService _InstructorServices,
            IStdWithCrService _IStdWithCrService, UserManager<IdentityUser> _UserManager,
            SignInManager<IdentityUser> _SignInManager, RoleManager<IdentityRole> _RoleManager)
        {
            StudentServices = _stdRepo;
            TrackServices = _trkRepo;
            InstructorServices = _InstructorServices;
            IStdWithCrService = _IStdWithCrService;
            UserManager = _UserManager;
            SignInManager = _SignInManager;
            RoleManager = _RoleManager;
        }

        [Route("Students")]
        public IActionResult GetAll()
        {
            ViewData["Trs"] = TrackServices.GetAll();
            return View(StudentServices.GetAll());
        }

        // Student/GetById
        //[Route("Student/id:int")]
        public IActionResult GetById([FromRoute] int id)
        {
            ViewData["Trs"] = TrackServices.GetAll();
            ViewData["IStdWithCr"] = IStdWithCrService.GetAll();
            return View(StudentServices.GetById(id));
        }

        // Student/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["listOfUser"] = UserManager.Users.Select(x => x.UserName).ToList();
            ViewData["Trs"] = TrackServices.GetAll();
            ViewData["insts"] = InstructorServices.GetAll();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Student newstd)///Save not create -> create not save ya mayadaw
        {
            if (ModelState.IsValid)
            {
                //save db
                StudentServices.Create(newstd);
                //display index view
                return RedirectToAction("GetAll");
            }
            ViewData["Trs"] = TrackServices.GetAll();
            ViewData["insts"] = InstructorServices.GetAll();
            return View(newstd);//html
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewData["Trs"] = TrackServices.GetAll();
            ViewData["insts"] = InstructorServices.GetAll();
            Student std = StudentServices.GetById(id);
            return View(std);
        }
        [HttpPost]
        public IActionResult Update(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                StudentServices.Update(newStudent);
                return RedirectToAction("GetAll");
            }
            ViewData["Trs"] = TrackServices.GetAll();
            ViewData["insts"] = InstructorServices.GetAll();
            return View(newStudent);
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

        public IActionResult Exisit(string Name, int id)
        {
            Student std = StudentServices.GetByName(Name);
            //case Add New Student
            if (id == 0)
            {
                if (std == null)
                    return Json(true);
                return Json(false); //name exists
            }
            else  //edit
            {
                if (std == null)
                    return Json(true); //update name with new value not exist before
                else
                {
                    if (std.Id == id)
                        return Json(true); //update
                    return Json(false);
                }
            }
        }

        // Student/GetStudent
       
        public IActionResult GetStudent(int id)
        {
            StdWithCr crs = IStdWithCrService.Get(id);
            StudentWithCrsDegreeVM stdVM = new StudentWithCrsDegreeVM();
            stdVM.StudentName = crs.Student.Name;
            stdVM.CrsName = crs.Course.Name;
            stdVM.Degree = crs.Degree;
            stdVM.Id = crs.Id;
            return View(stdVM);
        }

        //public IActionResult getInstructors(int id)
        //{
        //    List<Instructor> instModel = StudentServices.GetAllInstById(id);
        //    return View("ShowAllInstructors", instModel);//connection betwen view with model
        //}
    }

}

