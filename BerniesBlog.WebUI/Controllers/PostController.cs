using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BerniesBlog.Domain.Abstract;

namespace BerniesBlog.WebUI.Controllers
{
    public class PostController : Controller
    {
        private IBlogPost blogPost;

        public PostController(IBlogPost paramBlogPost)
        {
            blogPost = paramBlogPost;
        }
        
        // GET: Post
        public ActionResult PostToView()
        {

            return View();
        }
    }
}