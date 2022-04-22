using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Add1()
        {
            if (TempData["res"] != null)
                ViewBag.res = TempData["res"];
            return View();
        }


        [HttpPost]
        public ActionResult Add2()
        {
            int no1 = Byte.Parse( Request["txtNo1"]);
            int no2 = Byte.Parse(Request["txtNo2"]);

            int res = no1 + no2;
            TempData["res"] = res;
            return RedirectToAction("Add1");
        }
        public ActionResult Add3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add3(FormCollection formCollection)
        {
            int no1 = Byte.Parse(formCollection["txtNo1"]);
            int no2 = Byte.Parse(formCollection["txtNo2"]);

            int res = no1 + no2;
            ViewBag.res = res;

            return View();
        }

        public ActionResult Add4()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add4(int txtNo1, int txtNo2)
        {
            int res = txtNo1 + txtNo2;
            ViewBag.res = res;

            return View();
        }
        public ActionResult Add5()
        {
            return View(new Numbers());
        }

        [HttpPost]
        public ActionResult Add5(Numbers numbers)
        {
            int res = numbers.No1 + numbers.No2;
            ViewBag.res = res;
            return View();
        }
    }
}