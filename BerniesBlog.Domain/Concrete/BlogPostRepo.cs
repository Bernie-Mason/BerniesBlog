using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Instrumentation;
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

        public void SavePost(BlogPost post)
        {
            if (post.Id == 0)
            {
                context.BlogPosts.Add(post);
            }
            else
            {
                BlogPost dbEntry = context.BlogPosts.Find(post.Id);
                if (dbEntry != null)
                {
                    dbEntry.CreationDateTime = post.CreationDateTime;
                    dbEntry.Description = post.Description;
                    dbEntry.FolderName = post.FolderName;
                    dbEntry.Name = post.Name;
                    dbEntry.PostTitle = post.PostTitle;
                }
            }
            context.SaveChanges();
        }

        public BlogPost DeleteBlogPost(int Id)
        {
            BlogPost dbEntry = context.BlogPosts.Find(Id);
            if (dbEntry != null)
            {
                context.BlogPosts.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
