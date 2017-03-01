using System.Web.Mvc;

namespace BerniesBlog.WebUI.Areas.Blog
{
    public class BlogAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Blog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Blog_default",
                "Blog/{controller}/{action}/{Name}",
                new { controller  = "Post", action = "Index", Name = UrlParameter.Optional }
            );
        }
    }
}