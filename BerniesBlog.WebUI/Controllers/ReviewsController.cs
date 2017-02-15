using BerniesBlog.Domain.Concrete;
using BerniesBlog.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BerniesBlog.Domain.Abstract;
using BerniesBlog.WebUI.Models;

namespace BerniesBlog.WebUI.Controllers
{
    public class ReviewsController : Controller
    {
        private IRestaurantRepository repository;

        public ReviewsController(IRestaurantRepository repositoryParam)
        {
            repository = repositoryParam;
        }
        // GET: Reviews
        public ActionResult Index([Bind(Prefix="id")] int restaurantId) // Bind allows us to tell the MVC model binder that when it goes to look for the restaurant id parameter value, look for something called id
        {
            var restaurant = repository.Restaurants.Find(restaurantId);
            if( restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();
        }
        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReviews review)
        {
            if (ModelState.IsValid)
            {
                repository.Reviews.Add(review); // Tells the entity framework to add the review to the reviews collection. This doesn't save to the database
                repository.SaveChanges(); // At this point Insert, Update or Delete statements are used to make changes in the database
                return RedirectToAction("Index", new { id = review.RestaurantId }); // If it works then the user is redirected to the index action
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = repository.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RestaurantReviews review)
        {
            if (ModelState.IsValid)
            {
                repository.Entry(review).State = EntityState.Modified; // Slightly different API to the one in create. The Entry API is a way to tell the Entity database that 'here is a review that I want you to start tracking so that you can make changes in the database for this review
                repository.SaveChanges(); // At this point Insert, Update or Delete statements are used to make changes in the database
                return RedirectToAction("Index", new { id = review.RestaurantId }); // If it works then the user is redirected to the index action
            }
            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
            repository.Dispose();
            base.Dispose(disposing);
        }

    }
}
