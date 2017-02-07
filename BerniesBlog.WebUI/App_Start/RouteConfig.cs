using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BerniesBlog.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); 
            // Above: The routing engine will not try to process a request that will reach a real file on the file system
            // For example, we can request an image or css file without needing a routing engine for it.

            routes.MapRoute(
                name: "Post",
                url: "Post/{name}",
                defaults: new { controller = "Post", action = "Search", name = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
