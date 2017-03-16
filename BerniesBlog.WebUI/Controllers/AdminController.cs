using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using BerniesBlog.Domain.Abstract;
using BerniesBlog.Domain.Entities;
using BerniesBlog.WebUI.Models;

namespace BerniesBlog.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IBlogPost blogPostRepo;

        public AdminController(IBlogPost repo)
        {
            blogPostRepo = repo;
        }
        public BlogPostListViewModel model = new BlogPostListViewModel();
        

        public ActionResult Index()
        {
            model.SetBlogPosts(blogPostRepo, false);
            List<BlogPostViewModel>selectedModel = model.BlogPosts.OrderByDescending(b => b.CreationDateTime).ToList();
           
            return View(selectedModel);
        }

        public ViewResult Create()
        {
            BlogPostViewModel post = new BlogPostViewModel();
            return View(post);
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            blogPostRepo.DeleteBlogPost(Id);
            BlogPostViewModel post = new BlogPostViewModel();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Create(BlogPostViewModel createdPost)
        {
            if (ModelState.IsValid)
            {
                BlogPost toSave = new BlogPost
                {
                    Name = createdPost.Name,
                    FolderName = createdPost.FolderName,
                    Description = createdPost.Description,
                    CreationDateTime = createdPost.CreationDateTime,
                    Id = createdPost.Id,
                    PostTitle = createdPost.PostTitle
                };
                blogPostRepo.SavePost(toSave);
                TempData["message"] = string.Format("{0} has been saved", createdPost.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(createdPost);
            }
        }

        public ViewResult Edit(int Id)
        {
            model.SetBlogPosts(blogPostRepo, false);
            BlogPostViewModel post = model.BlogPosts
                .FirstOrDefault(b => b.Id == Id);
            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(BlogPostViewModel editedPost)
        {
            if (ModelState.IsValid)
            {
                BlogPost toSave = new BlogPost
                {
                    Name = editedPost.Name,
                    FolderName = editedPost.FolderName,
                    Description = editedPost.Description,
                    CreationDateTime = editedPost.CreationDateTime,
                    Id = editedPost.Id,
                    PostTitle = editedPost.PostTitle
                };
                blogPostRepo.SavePost(toSave);
                TempData["message"] = string.Format("{0} has been saved", editedPost.Name);
                return RedirectToAction("Index");

            }
            else
            {
                return View(editedPost);
            }
        }
    }
}