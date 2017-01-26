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
        RestaurantReviewsDB _db = new RestaurantReviewsDB();

        public ActionResult Index()
        {
            // The information of the route data is available anywhere throughout the request!
            // The RouteData is a data structure that is used to contain the route data
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"]; // We don't actually have to look inside route data to get the id

            var message = String.Format("{0}::{1} {2}", controller, action, id);
            ViewBag.Message = message;
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
            var model = _db.Restaurants.ToList();

            return View(model);
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

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}