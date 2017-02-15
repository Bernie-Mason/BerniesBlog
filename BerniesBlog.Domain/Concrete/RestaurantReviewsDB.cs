using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BerniesBlog.Domain.Entities;
using BerniesBlog.Domain.Abstract;

namespace BerniesBlog.Domain.Concrete
{
    //public class RestaurantReviewsDBWrapper : IRestaurantRepository
    //{

    //}
    public class RestaurantReviewsDB : DbContext, IRestaurantRepository
    {
        public RestaurantReviewsDB() : base("name = RestaurantReviewsDB")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReviews> Reviews { get; set; }

    }

    public class doWork
    {
        RestaurantReviewsDB _db = new RestaurantReviewsDB();
        
    }
}

namespace BerniesBlog
{
    public class WebUI
    {
    }
}
