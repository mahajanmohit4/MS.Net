using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //only receiving id
        //url will be http://localhost:57000/Controller/Action/Id
        public ActionResult First(int id = 0)
        {
            ViewBag.Id = id;
            return View();
        }

        //receiving other parameters
        //url will be http://localhost:57000/Controller/Action/Id?a=10&b=20&c=Vik

        public ActionResult Second(int id = 0, int a = 0, int b = 0, string c = "")
        {
            ViewBag.Id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}