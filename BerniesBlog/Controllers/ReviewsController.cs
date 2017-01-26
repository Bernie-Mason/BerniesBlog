//using BerniesBlog.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace BerniesBlog.Controllers
//{
//    public class ReviewsController : Controller
//    {
        
//        // GET: Reviews
//        public ActionResult Index()
//        {
//            var model = _db.Reviews.ToList();

//            return View(model);
//        }

//        // GET: Reviews/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Reviews/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Reviews/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Reviews/Edit/5
//        public ActionResult Edit(int id)
//        {
//            var review = _reviews.Single(r => r.Id == id);

//            return View(review);
//        }

//        // POST: Reviews/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            if (TryUpdateModel(review))
//            {
//                return RedirectToAction("Index"); // After the data has been posted it is common to redirect the user back to original page
//            }
//            return View(review);
//        }

//        // GET: Reviews/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Reviews/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // In memory data so we don't have to focus on data access yet:
//        // We wouldn't normally do this obviously...
//        static List<RestaurantReviews> _reviews = new List<RestaurantReviews>
//        {
//            new RestaurantReviews
//            {
//                Id = 1,
//                Name = "WokyKo",
//                City = "Bristol",
//                Country = "UK",
//                Rating = 8,
//            },
//            new RestaurantReviews
//            {
//                Id = 2,
//                Name = "Mountain Sun",
//                City = "Boulder",
//                Country = "US",
//                Rating = 7,
//            },
//            new RestaurantReviews
//            {
//                Id = 3,
//                Name = "Stieglbrau",
//                City = "Salzburg",
//                Country = "Austria",
//                Rating = 9,
//            },
//            new RestaurantReviews
//            {
//                Id = 4,
//                Name = "Ferdinands",
//                City = "Prague",
//                Country = "Czech Republic",
//                Rating = 8,
//            },

//        };
//    }
//}
