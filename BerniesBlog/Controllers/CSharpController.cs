using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerniesBlog.Controllers
{
    public class ProgrammingController : Controller
    {
        // GET: CSharp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObjectOriented()
        {
            return View();
        }

        public ActionResult CSharpIntro()
        {
            return View();
        }

        public ActionResult JavaScriptIntro()
        {
            return View();
        }
    }
}