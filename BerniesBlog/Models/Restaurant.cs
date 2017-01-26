using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BerniesBlog.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<RestaurantReviews> Reviews { get; set; }
    }
}