using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "Hello <b> World <b>";
        //}

        public ActionResult Method2()
        {
            return View();
        }
        public ActionResult Method3()
        {
            return View();
        }
        //only reciving id
        public ActionResult First(int id=0)
        {
            ViewBag.Id = id;
            return View();
        }
        //receving other parameters
        public ActionResult Second(int id = 0, int a=0, int b=0, string c="")
        {
            ViewBag.Id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;
            return View();
        }
    }
}