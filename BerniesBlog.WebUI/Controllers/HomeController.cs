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
        public bool selectPostsBasedOnPaging = true;
        public int PageSize = 5;
        public HomeController(IBlogPost paramBlogPost)
        {
            blogPostRepo = paramBlogPost;
        }

        public ViewResult Index(int page = 1)
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

            BlogPostListViewModel model = new BlogPostListViewModel();
            model.PagingInfo.CurrentPage = page;
            model.PagingInfo.ItemsPerPage = PageSize;
            model.PagingInfo.TotalItems = blogPostRepo.blogPosts.Count();
            model.SetBlogPosts(blogPostRepo, selectPostsBasedOnPaging); // The BlogPosts in BlogPostListViewModel to the posts in the repo

            BlogPostListViewModel selectedModel = new BlogPostListViewModel
            {
                BlogPosts = model.BlogPosts
                .OrderBy(b => b.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToList(),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = blogPostRepo.blogPosts.Count()
                }
            };

            return View(model);
        }

        public ActionResult Post(string Name, string FolderName, string Title)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                ViewBag.BlogTitle = Title;
            }

            if (!string.IsNullOrWhiteSpace(Name))
            {
                if (!string.IsNullOrWhiteSpace(FolderName))
                {
                    ViewBag.RelPathName = "/Views/Archive/" + FolderName + "/" + Name + ".cshtml";
                    return View();
                }
                ViewBag.RelPathName = "/Views/Archive/" + Name + ".cshtml";
                return View();
            }
            return RedirectToAction("Index");
        }

        //public RedirectToRouteResult RandomPost()
        //{
        //    Random rnd = new Random();
        //    int postIndex = rnd.Next(0, (blogPostRepo.blogPosts.Count()-1));
        //    BlogPostListViewModel model = new BlogPostListViewModel();
        //    model.SetBlogPosts(blogPostRepo, selectPostsBasedOnPaging); // The BlogPosts in BlogPostListViewModel to the posts in the repo
        //    List<BlogPostViewModel> modelList = model.BlogPosts;
        //    BlogPostViewModel asdf = from BlogPostViewModel in modelList
        //                             where 

        //    BlogPostListViewModel selectedModel = new BlogPostListViewModel
        //    {
        //        BlogPosts = model.BlogPosts
        //        .OrderBy(b => b.Id)
        //        .Skip(postIndex)
        //        .Take(1)
        //        .ToList(),
        //    };

        //    return RedirectToAction("Post", new { selectedModel, FolderName, Title } );
        //}

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


    }
}