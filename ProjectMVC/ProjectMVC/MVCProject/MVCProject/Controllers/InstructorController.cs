using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Service;
using System.Collections.Generic;

namespace MVCProject.Controllers
{
    public class InstructorController : Controller
    {
        IInstructorService InsRepo;
        ITrackService TrackRepo;
        public InstructorController(IInstructorService Insrepo, ITrackService trackRepo)
        {
            InsRepo = Insrepo;
            TrackRepo = trackRepo;
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
            if (id == 0)   //add
            {
                Instructor ins = InsRepo.GetByName(Name);
                if (ins == null)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            else           //edit
            {
                Instructor ins = InsRepo.GetByName(Name);
                if (ins == null)
                {
                    return Json(true);
                }
                else
                {
                    if (ins.Id == id)
                        return Json(true);
                    else
                        return Json(false);
                }

            }

        }

       
        public IActionResult Index()
        {
            List<Instructor> insModel = InsRepo.GetAll();
            return View("Index", insModel);
        }

        public IActionResult Detail(int id)
        {
            List<Instructor> gModel = InsRepo.GetAllById(id);
            return View("Detail", gModel);
        }

        public IActionResult add()
        {

            List<Track> tracks = TrackRepo.GetAll();
            ViewBag.tracks = tracks;

            Instructor ins = new Instructor();
            return View(ins);


        }

        [HttpPost]
        public IActionResult saveadd(Instructor newins)
        {
            
            if (ModelState.IsValid == true)
            {

                InsRepo.Create(newins);
                return RedirectToAction("Index");
            }

            List<Track> tracks = TrackRepo.GetAll();
            ViewBag.tracks = tracks;
            return View("add", newins);
        }

        public IActionResult edit(int id)
        {

            List<Track> tracks = TrackRepo.GetAll();
            ViewBag.tracks = tracks;

            Instructor std = InsRepo.GetById(id);
            return View(std);
        }

        public IActionResult saveEdit([FromRoute] int id, Instructor newins)
        {
            if (ModelState.IsValid == true)
            {
                Instructor ins = InsRepo.GetById(id);
                InsRepo.Update(id,newins);
                return RedirectToAction("Index");
            }

            List<Track> tracks = TrackRepo.GetAll();
            ViewBag.tracks = tracks;

            Instructor std = InsRepo.GetById(id);
            return View("Index", std);

        }
    }
}
