using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerniesBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Post()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A little about me";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Food()
        {
            return View();
        }

        public ActionResult Magic()
        {
            return View();
        }

        public ActionResult Languages()
        {
            return View();
        }

        public ActionResult Running()
        {
            return View();
        }
    }
}