using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BerniesBlog.WebUI.Models
{
    public class BlogPostViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please state a file name")]
        [Display(Name = "File name")]
        public string Name { get; set; }

        [Display(Name = "Folder name")]
        public string FolderName { get; set; }

        [Required(ErrorMessage = "Please give a title to the post")]
        [Display(Name = "Post Title")]
        public string PostTitle { get; set; }

        [Required(ErrorMessage = "Please give a description")]
        [Display(Name = "Post description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please set a valid date")]
        [Display(Name = "Creation date and time")]
        public DateTime CreationDateTime { get; set; }

        //public BlogPostViewModel()

    }
}
