using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
namespace WebApplication7.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> list = new List<Student>()
        {
            new Student() { Id=1, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=2, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=3, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=4, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=5, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=6, Name="Ajay", Batch="B001", Marks=90}
        };
            ViewBag.list = list;
            return View();
        }

        public ActionResult Details()
        {
            Student student = new Student()
            { Id = 100, Name = "Deepak", Batch = "B001", Marks = 90 };
            ViewBag.student = student;
            return View();
        }

        public ActionResult Details1()
        {
            Student student = new Student()
            { Id = 100, Name = "Deepak", Batch = "B001", Marks = 90 };
            return View(student);
        }
        public ActionResult Index1()
        {
            List<Student> list = new List<Student>()
        {
            new Student() { Id=1, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=2, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=3, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=4, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=5, Name="Ajay", Batch="B001", Marks=90},

            new Student() { Id=6, Name="Ajay", Batch="B001", Marks=90}
        };
            
            return View(list);
        }

    }
}