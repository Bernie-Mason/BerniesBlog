using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BerniesBlog.Domain.Entities
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FolderName { get; set; }
        public string PostTitle { get; set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; set; }
        
    }
}
