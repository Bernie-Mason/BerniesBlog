using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerniesBlog.WebUI.Filters
{
    public class MyPropertyActionFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.DefaultPageHeader = "Bernie's Blog";
            filterContext.Controller.ViewBag.DefaultPageSubHeader = "A Place For Nonsense";
        }
    }
}