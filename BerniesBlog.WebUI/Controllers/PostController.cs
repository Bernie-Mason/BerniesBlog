using BerniesBlog.WebUI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerniesBlog.WebUI.Controllers
{
    public class PostController : Controller
    {
        [Log]
        public ActionResult Search(string name = "Post")
        {
            var message = Server.HtmlEncode(name); //This will make sure that if a user passes any malicious script code in the URL then it will render as html
            return Content(message);
        }


    }
}