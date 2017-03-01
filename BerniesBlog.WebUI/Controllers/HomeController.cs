using BerniesBlog.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BerniesBlog.Domain.Abstract;

namespace BerniesBlog.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBlogPost blogPostRepo;
        public int PageSize = 4;
        public HomeController(IBlogPost paramBlogPost)
        {
            blogPostRepo = paramBlogPost;
        }

        public ActionResult Index(int page = 1)
        {
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
            BlogPostViewModel model = new BlogPostViewModel
            {
                BlogPosts = blogPostRepo.blogPosts
                .OrderBy(b => b.Id)
                .Skip((page-1)*PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    CurrentPage = page,
                    TotalItems = blogPostRepo.blogPosts.Count()
                }
            };

            //Return view
            return View(model);
        }

        public ActionResult Post(string Name)
        {
            if (Name != null)
            {
                ViewBag.FileName = Name;
                return View();
            }
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "A little about me";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        public ActionResult Running()
        {
            return View();
        }

    }
}