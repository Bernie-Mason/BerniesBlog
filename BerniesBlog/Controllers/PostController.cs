using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerniesBlog.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name); //This will make sure that if a user passes any malicious script code in the URL then it will render as html
            return Content(message);
        }
    }
}