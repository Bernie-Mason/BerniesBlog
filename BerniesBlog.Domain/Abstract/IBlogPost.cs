using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.Domain.Abstract
{
    public interface IBlogPost
    {
        IEnumerable<BlogPost> blogPosts { get; }
        void SavePost(BlogPost post);
        BlogPost DeleteBlogPost(int Id);
    }
}
