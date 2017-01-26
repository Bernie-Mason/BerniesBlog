using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BerniesBlog.Models
{
    public class RestaurantReviewsDB :DbContext
    {
        public RestaurantReviewsDB() : base("name = DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReviews> Reviews { get; set; }
    }
}