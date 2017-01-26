using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerniesBlog.Filters
{
    public class MyPropertyActionFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.DefaultPageTitle = "Bernie's Blog";
            filterContext.Controller.ViewBag.DefaultPageSubTitle = "A Place For Nonsense";
        }
    }
}