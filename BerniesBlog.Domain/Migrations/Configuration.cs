using System.IO;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BerniesBlog.Domain.Concrete.BlogPostDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BerniesBlog.Domain.Concrete.BlogPostDBContext";
        }

        protected override void Seed(BerniesBlog.Domain.Concrete.BlogPostDBContext context)
        {

            //string[] fileEntries =
            //    Directory.GetFiles(
            //        @"C:\Users\Bernie\Documents\Visual Studio 2015\Projects\BerniesBlog\BerniesBlog.WebUI\Views\Archive\Programming\",
            //        "*.cshtml");
            //foreach (string fileEntry in fileEntries)
            //{
            //    context.BlogPosts.AddOrUpdate(
                    
            //            new BlogPost()
            //            {
                            
            //            }
                    
                
            //    );
            //}

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
