using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.WebUI.Models
{
    public class BlogPostViewModel
    {
        public IEnumerable<BlogPost> BlogPosts { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}