using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BerniesBlog.WebUI.Startup))]
namespace BerniesBlog.WebUI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
