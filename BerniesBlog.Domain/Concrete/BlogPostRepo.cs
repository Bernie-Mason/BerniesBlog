using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerniesBlog.Domain.Abstract;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.Domain.Concrete
{
    public class BlogPostRepo : IBlogPost
    {
        private BlogPostDBContext context = new BlogPostDBContext();

        public IEnumerable<BlogPost> blogPosts
        {
            get { return context.BlogPosts; } 
            
        }
    }
}
