using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\guesttta\Documents\GitHub\Tech_Academy_C-Sharp_Coding_Projects\Mvc.txt", text);
            //return View();

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 20000)

            {
                //return RedirectToAction("Contact");
                //return Content("Hello!");
            }

            return View();

            //ViewBag.RandomNumber = num;

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}