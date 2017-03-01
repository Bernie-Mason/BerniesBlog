using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.Domain.Concrete
{
    public class BlogPostDBContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }

    }
}
