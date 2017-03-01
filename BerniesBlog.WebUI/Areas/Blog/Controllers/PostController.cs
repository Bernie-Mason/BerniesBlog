using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerniesBlog.WebUI.Areas.Blog.Controllers
{
    public class PostController : Controller
    {
        // GET: Blog/Post
        public ActionResult Index(string Name)
        {
            if (Name != null)
            {
                return View(Name);
            }
            return RedirectToAction("Index");
        }
    }
}