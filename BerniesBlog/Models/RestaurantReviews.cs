using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BerniesBlog.Models
{
    public class RestaurantReviews
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
        public int RestaurantId { get; set; }
    }
}