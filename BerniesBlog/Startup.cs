using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BerniesBlog.Startup))]
namespace BerniesBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
