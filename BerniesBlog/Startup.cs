﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BerniesBlog.Startup))]
namespace BerniesBlog
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
