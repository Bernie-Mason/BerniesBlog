using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BerniesBlog.Domain.Abstract;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.WebUI.Models
{
    public class BlogPostListViewModel
    {
        public List<BlogPostViewModel> BlogPosts { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public BlogPostListViewModel()
        {
            BlogPosts = new List<BlogPostViewModel>();
            PagingInfo = new PagingInfo();
        }

        public void SetBlogPosts(IBlogPost blogPostRepo, bool selectPostsBasedOnPaging)
        {
            foreach (var item in blogPostRepo.blogPosts)
            {
                BlogPostViewModel viewModel = new BlogPostViewModel()
                {
                    Id = item.Id,
                    CreationDateTime = item.CreationDateTime,
                    Description = item.Description,
                    FolderName = item.FolderName,
                    Name = item.Name,
                    PostTitle = item.PostTitle
                };
                BlogPosts.Add(viewModel);
            }

            if (selectPostsBasedOnPaging && PagingInfo != null)
            {
                List<BlogPostViewModel> tempBlogList = BlogPosts
                    .OrderBy(b => b.Id)
                    .Skip((PagingInfo.CurrentPage - 1) * PagingInfo.ItemsPerPage)
                    .Take(PagingInfo.ItemsPerPage)
                    .ToList();

                BlogPosts = tempBlogList;
                
            }
        }

        
    }
}

//class Foo
//{
//    public Foo()
//    {
//        Bars = new List<Bar>();
//    }

//    public Foo(int hoCount)
//    : this()
//    {
//        if (hoCount < 0) throw new Exception("Invalid ho count");
//    }

//    public List<Bar> Bars { get; set; }
//}