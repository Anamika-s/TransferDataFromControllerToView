using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class StudentsController : Controller
    {
       static List<Student> listStudents = null;
        public StudentsController()
        {
if(listStudents == null)
            {
                listStudents = new List<Student>()
            {
                new Student() { Id =1, Name="Ajay", Batch="B001", Marks=90},

                new Student() { Id =2, Name="Deepak", Batch="B001", Marks=90},

                new Student() { Id =3, Name="Jay", Batch="B001", Marks=90},

                new Student() { Id =4, Name="Ajay", Batch="B001", Marks=90},

                new Student() { Id =5, Name="Ajay", Batch="B001", Marks=90}
            };
                 
            }
        }
        // GET: Students
        public ActionResult Index()
        {
            return View(listStudents.ToList()) ;
        }


        public ActionResult Details(int id)
        {
            var student = listStudents.FirstOrDefault
                (x => x.Id == id);
            if (student == null)

                ViewBag.msg = "Record wth this ID do not exist";
            return View(student);
        }

        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            listStudents.Add(student);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            var student = listStudents.FirstOrDefault
               (x => x.Id == id);
            if (student == null)

                ViewBag.msg = "Record wth this ID do not exist";
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            var obj = listStudents.FirstOrDefault
              (x => x.Id == id);
            foreach(var temp in listStudents)
            {
                if(temp.Id ==  obj.Id)
                {
                    temp.Batch = student.Batch;
                    temp.Marks = student.Marks;
                }
            }
            return RedirectToAction("Index");

        }


        public ActionResult Delete(int id)
        {
            var student = listStudents.FirstOrDefault
               (x => x.Id == id);
            if (student == null)

                ViewBag.msg = "Record wth this ID do not exist";
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(int id, Student student)
        {
            var obj = listStudents.FirstOrDefault
              (x => x.Id == id);
            listStudents.Remove(obj);
            return RedirectToAction("Index");

        }
    }
}