using BerniesBlog.Models;
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
            // The information of the route data is available anywhere throughout the request!
            // The RouteData is a data structure that is used to contain the route data
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"]; // We don't actually have to look inside route data to get the id

            var message = String.Format("{0}::{1} {2}", controller, action, id);
            ViewBag.Message = message;

            // Message to be inserted in subtitle of homepage only
            int hour = DateTime.Now.Hour;
            string Day = DateTime.Now.DayOfWeek.ToString();
            string greeting;
            if (hour < 5) { greeting = "You're up early!"; }
            else if (hour < 12) { if (Day == "Friday") { greeting = "Happy Friday!"; } else { greeting = "Good morning!"; } }
            else if (hour < 13) { greeting = "Happy lunchtime!"; }
            else if (hour < 18) { if (Day == "Friday") { greeting = "Happy Friday!"; } else { greeting = "Good afternoon!"; } }
            else if (hour < 21) { greeting = "Good evening!"; }
            else { greeting = "Good night!"; }

            ViewBag.GreetingMessage = greeting;
            

            //Return view
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