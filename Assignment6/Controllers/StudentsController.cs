using Assignment6.Models;
using Assignment6.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Controllers
{
    public class StudentsController : Controller
    {
        SchoolRepository repo = new SchoolRepository();

        // GET: Default
        public ActionResult Index()
        {
            return View(repo.GetAllStudents());
        }

        public ActionResult Create()
        {
            ViewBag.ClassID = new SelectList(repo.GetAllClasses(), "ClassID", "ClassName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,StudentName,ClassID")] Student student)
        {
            if (ModelState.IsValid)
            {
                repo.AddStudent(student);
                return RedirectToAction("Index");
            }

            ViewBag.ClassID = new SelectList(repo.GetAllClasses(), "ClassID", "ClassName", student.ClassID);
            return View(student);
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = repo.GetStudentDetails(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.ClassID = new SelectList(repo.GetAllClasses(), "ClassID", "ClassName");
            return View();
        }
    }
}