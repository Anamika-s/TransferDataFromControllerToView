using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            if(TempData["name"]!=null)
            {
                ViewBag.name = TempData["name"];
            }
            ViewBag.date = DateTime.Now.ToString();
            return View();
        }
        public ActionResult Index1()
        {
            ViewData["data"] = DateTime.Now.ToString();
            return View();
        }

        public ActionResult Index3()
        {
            TempData["name"] = "Ajay Kumar";
            return RedirectToAction("Index");
        }


    }
}