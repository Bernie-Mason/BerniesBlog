using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.Domain.Concrete
{
    public class RestaurantReviewsDB : DbContext
    {
        public RestaurantReviewsDB() : base("name = DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReviews> Reviews { get; set; }
    }
}
