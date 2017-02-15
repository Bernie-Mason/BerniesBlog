using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BerniesBlog.WebUI.Models;
using BerniesBlog.Domain.Abstract;
using BerniesBlog.Domain.Entities;
using BerniesBlog.Domain.Concrete;

namespace BerniesBlog.WebUI.Controllers
{
    public class RestaurantsController : Controller
    {
        private IRestaurantRepository repository;
        public int PageSize = 4;

        public RestaurantsController(IRestaurantRepository repositoryParam)
        {
            repository = repositoryParam;
        }

        // GET: Restaurants
        public ActionResult Index(string searchTerm = null, int page = 1)
        {
            RestaurantListViewModel model = new RestaurantListViewModel()
            {
                Restaurants = repository.Restaurants
                    .OrderByDescending(r => r.Reviews.Average(reviews => reviews.Rating))
                    .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm)),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Restaurants.Count()
                }
            };
            
            return View(model);
        }

        // GET: Restaurants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurant restaurant = repository.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        // GET: Restaurants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,City,Country")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                repository.Restaurants.Add(restaurant);
                repository.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurant);
        }

        // GET: Restaurants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurant restaurant = repository.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            RestaurantViewModel restaurantIn = new RestaurantViewModel
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                City = restaurant.City,
                Country = restaurant.Country,
            };

            return View(restaurantIn);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,City,Country")] IRestaurantRepository restaurant)
        {
            if (ModelState.IsValid)
            {
                repository.Entry(restaurant).State = EntityState.Modified;
                repository.SaveChanges();
                return RedirectToAction("Index");
            }
            //RestaurantViewModel restaurantIn = new RestaurantViewModel
            //{
            //    Id = restaurant.Id,
            //    Name = restaurant.Name,
            //    City = restaurant.City,
            //    Country = restaurant.Country,
            //};
            return View(restaurant);
        }

        // GET: Restaurants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurant restaurant = repository.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            RestaurantViewModel restaurantIn = new RestaurantViewModel
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                City = restaurant.City,
                Country = restaurant.Country,
            };
            return View(restaurantIn);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurant restaurant = repository.Restaurants.Find(id);
            repository.Restaurants.Remove(restaurant);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repository.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}



